using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.ptit.qldsv.service
{
    class ValidationService
    {
        public bool validateTextEditNotBlank(DevExpress.XtraEditors.TextEdit txtEdit)
        {
            bool result = true;
            if(txtEdit.Text.Trim() == "")
            {
                result = false;
            }
            return result;
        }
    }
}
