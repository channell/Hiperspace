using Hiperspace;
using System.Linq;

namespace Access
{
    public partial class AccessSpace : Hiperspace.SubSpace
    {
        public enum Mode
        {
            ILoad,      // for inital load permissions will fail
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
            new Horizon<RBAC.Realm>(r => r.Valid == true && r.Name == realm.Name),
            new Horizon<RBAC.UserPermission>(p => p.Valid == true && p.Approved == true && p.owner?.Realm == realm), 
            new Horizon<RBAC.GroupPermission>(p => p.Valid == true && p.Approved == true && p.owner?.Realm == realm),
            new Horizon<RBAC.User>(u => u.Valid == true && u?.Realm == realm),
            new Horizon<RBAC.Group>(g => g.Valid == true && g?.Realm == realm),
            new Horizon<RBAC.Resource>(i => i.Valid == true),
        ];
        private static Horizon[] Write (RBAC.Realm realm) =>
        [
            new Horizon<RBAC.Realm>(r => r.Valid == true && r == realm),
            new Horizon<RBAC.UserPermission>(p => p.Valid == true && p.owner?.Realm == realm),
            new Horizon<RBAC.GroupPermission>(p => p.Valid == true && p.owner?.Realm == realm),
            new Horizon<RBAC.User>(u => u.Valid == true && u?.Realm == realm),
            new Horizon<RBAC.Group>(g => g.Valid == true && g?.Realm == realm),
            new Horizon<RBAC.Resource>(i => i.Valid == true),
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
                    foreach (var perm in (await tasks).Where(p => p.Approved == false))
                    {
                        if (perm.Approval != null)
                        {
                            foreach (var aprove in perm.Approval)
                            {
                                if (aprove.Value != null && groups.Contains(aprove.Value))
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
                    foreach (var perm in (await tasks).Where(p => p.Approved == false))
                    {
                        if (perm.Approval != null)
                        {
                            foreach (var aprove in perm.Approval)
                            {
                                if (aprove.Value != null && groups.Contains(aprove.Value))
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
