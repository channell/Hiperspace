using Hiperspace;

namespace Access.RBAC
{
    public partial class UserPermission
    {
        /// <summary>
        /// Approve the permission using optimistic locking
        /// </summary>
        /// <param name="user"></para   m>
        /// <param name="recurse"></param>
        /// <returns></returns>
        /// <exception cref="MutationException"></exception>
        /// <exception cref="AccessViolationException"></exception>
        public bool Approve(User user, int recurse = 0 )
        {
            if (recurse > 100)
                throw new MutationException($"Too many concurent updates");

            DateTime time = AsAt;
            if (user.Realm == null || user.Realm?.Value == null || SetSpace?.Space == null)
                return false;
            using (var scope = new AccessSpace(SetSpace.Space, AccessSpace.Mode.Write, user.Realm.Value.Value))
            {
                var perm = scope.UserPermissions.Get(this);
                var usr = scope.Users.Get(user);    // might have been updated
                if (usr == null)
                    throw new AccessViolationException($"User {user.Name} has been deleted");

                var groups = usr.Groups.Select(g => new RefGroup { Value = g }).ToHashSet();

                if (perm?.Approval == null || perm?.Required == null)
                    return false;

                groups.Intersect(perm.Approval);
                perm.Unbind(scope);                 // make mutable for change
                perm.Author = user;                 // audit
                perm.Required.UnionWith(groups);
                scope.UserPermissions.Bind(perm);
                time = perm.AsAt;
            }
            using (var scope = new AccessSpace(SetSpace.Space, AccessSpace.Mode.Write, user.Realm.Value.Value))
            {
                var perm = scope.UserPermissions.Get(this);
                if (perm != null && perm.AsAt > time)
                    return perm.Approve(user, ++recurse);
            }
            return true;
        }
    }
}
