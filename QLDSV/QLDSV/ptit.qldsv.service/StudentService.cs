using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.ptit.qldsv.service
{
    class StudentService
    {
        public bool getGender(BindingSource bindingSource)
        {
            bool gender = true;
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                gender = drow.Field<bool>("PHAI");
            } catch
            {

            }
            return gender;
        }
    }
}
