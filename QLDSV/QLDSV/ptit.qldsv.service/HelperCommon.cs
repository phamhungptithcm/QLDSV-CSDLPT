using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.ptit.qldsv.service
{
    static class HelperCommon
    {
        public static DataRow getDataRowFromBindingSource(BindingSource bindingSource)
        {
            DataRow drow = null;
            try
            {
                drow = ((DataRowView)bindingSource.Current).Row;
            } catch
            {
               
            }
            return drow;
        }
    }
}
