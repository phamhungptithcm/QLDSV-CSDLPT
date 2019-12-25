using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.ptit.qldsv.model
{
    class Role
    {
        private string roleName;
        private string roleId;

        public string RoleName
        {
            get
            {
                return roleName;
            }

            set
            {
                roleName = value;
            }
        }

        public string RoleId
        {
            get
            {
                return roleId;
            }

            set
            {
                roleId = value;
            }
        }
    }
}
