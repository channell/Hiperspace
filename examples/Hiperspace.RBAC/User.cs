using Access.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.RBAC
{
    public partial class User
    {
        /// <summary>
        /// All groups that this user is a member of
        /// </summary>
        public HashSet<Group?> Groups
        {
            get
            {
                var groups = new HashSet<Group?>();
                groups.Add(Group?.Value);
                var parent = Group?.Value?.Parent?.Value;
                while (parent != null)
                {
                    groups.Add(parent);
                    parent = parent.Parent?.Value;
                }

                return groups;
            }
        }
    }
}
