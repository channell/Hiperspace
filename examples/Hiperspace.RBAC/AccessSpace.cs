using Hiperspace;

namespace Access
{
    public partial class AccessSpace : Hiperspace.SubSpace
    {
        public enum Mode
        {
            ILoad,      // for initial load permissions will fail
            Write,      // applies valid constraints
            Read        // applies valid constraint and permissions that have been approved
        }

        /// <summary>
        /// Horizon filters canot refer to properties that would require navigation
        /// </summary>
        /// <param name="realm"></param>
        /// <returns></returns>
        private static Horizon[] Read (RBAC.Realm realm) =>
        [
            new Horizon<RBAC.Realm>((r,c,read) => (read ? true : r.Valid == true) && r.Name == realm.Name),
            new Horizon<RBAC.UserPermission>((p,c,read) => (read ? true : p.Valid == true) && p.Deleted == false && p.Approved == true && p.owner?.Realm == realm), 
            new Horizon<RBAC.GroupPermission>((p,c,read) => (read ? true : p.Valid == true) && p.Deleted == false && p.Approved == true && p.owner?.Realm == realm),
            new Horizon<RBAC.User>((u,c,read) => (read ? true : u.Valid == true) && u.Deleted == false && u?.Realm == realm),
            new Horizon<RBAC.Group>((g,c,read) => (read ? true : g.Valid == true) && g.Deleted == false && g?.Realm == realm),
            new Horizon<RBAC.Resource>((i,c,read) => (read ? i.Valid == true : true) && i.Deleted == false),
        ];
        private static Horizon[] Write (RBAC.Realm realm) =>
        [
            new Horizon<RBAC.Realm>((r,c,read) => (read ? true : r.Valid == true) && r == realm),
            new Horizon<RBAC.UserPermission>((p,c,read) => (read ? true : p.Valid == true) && p.owner?.Realm == realm),
            new Horizon<RBAC.GroupPermission>((p,c,read) => (read ? true : p.Valid == true) && p.owner?.Realm == realm),
            new Horizon<RBAC.User>((u,c,read) => (read ? true : u.Valid == true) && u?.Realm == realm),
            new Horizon<RBAC.Group>((g,c,read) => (read ? true : g.Valid == true) && g?.Realm == realm),
            new Horizon<RBAC.Resource>((i,c,read) => (read ? true : i.Valid == true)),
        ];

        private static Horizon[] Unified(RBAC.Realm realm) =>
        [
            new Horizon<RBAC.Realm>((r,context,user,read) => (context == "ILoad" || ((read ? true : r.Valid == true) && r.Name == realm.Name)) && user?.IsInRole("BULK") == true) ,
            new Horizon<RBAC.UserPermission>((p,context,read) => context == "ILoad" || (p.Valid == true && ((p.Deleted == false && p.Approved == true) || context != "Read") && p.owner?.Realm == realm)),
            new Horizon<RBAC.GroupPermission>((p,context,read) => context == "ILoad" || (p.Valid == true && ((p.Deleted == false && p.Approved == true) || context != "Read") && p.owner?.Realm == realm)),
            new Horizon<RBAC.User>((u,context,read) => context == "ILoad" || (u.Valid == true && u.Deleted == false && u?.Realm == realm)),
            new Horizon<RBAC.Group>((g,context,read) => context == "ILoad" || (g.Valid == true && g.Deleted == false && g?.Realm == realm)),
            new Horizon<RBAC.Resource>((i,context,read) => context == "ILoad" || (i.Valid == true && i.Deleted == false)),
        ];

        /// <summary>
        /// Construct with predefined CQRS mode
        /// </summary>
        /// <param name="space">underlying HiperSpace that porovide store</param>
        /// <param name="mode">read or write</param>
        /// <param name="AsAt">snapshot date</param>
        public AccessSpace(HiperSpace space, Mode mode, RBAC.Realm realm, DateTime? AsAt = null) 
            : this(space, (mode == Mode.Write ? Write(realm) : (mode == Mode.Read ? Read (realm) : null)), AsAt)
        {
            ContextLabel = mode.ToString();
            _realm = realm;
        }
        protected RBAC.Realm? _realm;

        /// <summary>
        /// user approval task
        /// </summary>
        /// <param name="user">current user</param>
        /// <returns>user tasks they can approve</returns>
        /// <remarks>uses a scoped SubSpace to avoid caching of Access</remarks>
        public async Task<List<RBAC.UserPermission>> UserApprovalTasks(RBAC.User user)
        {
            var result = new List<RBAC.UserPermission>();
            if (user.Group != null && _realm != null && AsAt == null) // can't approve history
            {
                using (var scope = new AccessSpace(this, Write(_realm), AsAt))
                {
                    var tasks =
                        scope.UserPermissions
                        .FindAsync(new RBAC.UserPermission { Approved = false });

                    var groups = user.Groups;
                    await foreach (var perm in tasks)
                    {
                        if (perm.Approval != null && perm.Approved == false)
                        {
                            foreach (var approve in perm.Approval)
                            {
                                if (approve.Value != null && groups.Contains(approve.Value?.Value))
                                {
                                    result.Add(perm);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// user approval task
        /// </summary>
        /// <param name="user">current user</param>
        /// <returns>user tasks they can approve</returns>
        public async Task<List<RBAC.GroupPermission>> GroupApprovalTasks(RBAC.User user)
        {
            var result = new List<RBAC.GroupPermission>();
            if (user.Group != null && _realm != null && AsAt == null)     // can't approve history
            {
                using (var scope = new AccessSpace(this, Write(_realm), AsAt))
                {
                    var tasks =
                        scope.GroupPermissions
                        .FindAsync(new RBAC.GroupPermission { Approved = false });

                    var groups = user.Groups;
                    await foreach (var perm in tasks)
                    {
                        if (perm.Approval != null && perm.Approved == false)
                        {
                            foreach (var approve in perm.Approval)
                            {
                                if (approve.Value != null && groups.Contains(approve.Value?.Value))
                                {
                                    result.Add(perm);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
