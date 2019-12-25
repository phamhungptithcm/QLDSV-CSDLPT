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
        public const string KHOA = "Khoa";
        public const string PGV = "PGV";
        public const string PKT = "PKT";

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
        public static bool getListKhoa(ComboBox cmbKhoa)
        {
            bool result = false;
            try
            {
                if (!cmbKhoa.SelectedValue.ToString().Equals(""))
                {
                    DataRowView drow = (DataRowView)cmbKhoa.SelectedItem;
                    String servername = drow.Row.Field<String>("TENSERVER");
                    Program.servername = servername;
                }
                if (cmbKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                {

                }
                else
                {
                    result = true;
                }
            } catch
            {
               result = false;
            }
            return result;
        }
    }
}
