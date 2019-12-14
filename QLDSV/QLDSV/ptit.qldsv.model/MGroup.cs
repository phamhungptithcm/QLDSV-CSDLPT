using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.ptit.qldsv.model
{
    class MGroup
    {
        private String groupName;
        private String groupId;
        public MGroup(String groupId, String groupName)
        {
            this.groupId = groupId;
            this.groupName = groupName;
        }
        public string GroupName
        {
            get
            {
                return groupName;
            }

            set
            {
                groupName = value;
            }
        }

        public string GroupId
        {
            get
            {
                return groupId;
            }

            set
            {
                groupId = value;
            }
        }
    }
}
