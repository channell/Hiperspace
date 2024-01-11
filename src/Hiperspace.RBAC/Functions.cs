using Hiperspace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Access.RBAC
{
    public static class Functions
    {
        public static bool Empty<T>(RefSet<T> set) where T : Element<T>, new()
        {
            return set.Count == 0;
        }
        /// <summary>
        /// Is the permission full approved by every required approval group
        /// </summary>
        /// <param name="approved">set of approvals</param>
        /// <param name="required">set of reqwuired groups for approval</param>
        /// <returns></returns>
        public static bool Approved(HashSet<RefGroup>? approved, HashSet<RefGroup>? required)
        {
            if (required == null)
                return true;
            else if (approved == null)
                return false;
            else
            {
                foreach (var group in required)
                {
                    if (!approved.Contains(group))
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Does the user or their group or their role has the required permission for the subject
        /// </summary>
        /// <param name="user">user entered asd author</param>
        /// <param name="permission"></param>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static bool Authorised(KeyRef<User.KeyType, User>? user, PermissionType? permission, string? subject)
        {
            if (user == null || permission == null || subject == null)
                return false;
            if (user.Value.Value?.Permission == null)
                return false;

            foreach(var p in user.Value.Value.Permission)
            {
                if (p.Subject == subject && (permission | p.Right) == p.Right)
                    return true;
            }
            foreach (var role in user.Value.Value.Roles)
            {
                if (Authorised(role.Role?.Value, permission, subject))
                    return true;
            }
            return Authorised(user.Value.Value.Group?.Value, permission, subject);
        }
        private static bool Authorised(Group? group, PermissionType? permission, string? subject)
        {
            if (group == null || permission == null || subject == null)
                return false;

            foreach (var p in group.Permission)
            {
                if (p.Subject == subject && (permission | p.Right) == p.Right)
                    return true;
            }

            foreach (var role in group.Roles)
            {
                if (Authorised(role.Role?.Value, permission, subject))
                    return true;
            }

            if (group.Parent != null && group.Parent?.Value != null)
            {
                return Authorised(group.Parent.Value.Value, permission, subject);
            }

            return false;
        }
        private static bool Authorised(Role? role, PermissionType? permission, string? subject)
        {
            if (role == null || permission == null || subject == null)
                return false;

            foreach (var p in role.Permission)
            {
                if (p.Subject == subject && (permission | p.Right) == p.Right)
                    return true;
            }

            return false;
        }
        public static bool IsUserInRole(KeyRef<User.KeyType, User>? user, string? code)
        {
            if (user == null || user.Value.Value == null || code == null)
                return false;

            var userRole = new UserRoles { owner = user, Role = new Role { Code = code } };
            if (user.Value.Value.Roles.Contains(userRole))
                return true;

            return false;
        }
        internal static bool IsGroupInRole(KeyRef<Group.KeyType, Group>? group, string code)
        {
            if (group?.Value == null )
                return false;

            var groupRole = new GroupRoles { owner = group, Role = new Role { Code = code } };
            if (group.Value.Value.Roles.Contains(groupRole))
                return true;
            if (group.Value.Value.Parent != null && group.Value.Value.Parent?.Value != null)
            {
                return IsGroupInRole(group.Value.Value.Parent, code);
            }
            return false;
        }
    }
}
