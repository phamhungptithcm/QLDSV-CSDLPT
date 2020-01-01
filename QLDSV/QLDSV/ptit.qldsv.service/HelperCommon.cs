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
        public const string KHOA = "KHOA";
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
        public static void initDataCmbFromDB(ComboBox cmb,string tableName, string displayMember, string valueMember)
        {
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM "+tableName);
            cmb.DataSource = dt;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.SelectedIndex = 0;
        }
        public static DataTable queryDataByOneCondition(string tableName, string columnConditionName, string valueCondition)
        {
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM " + tableName + " WHERE " + columnConditionName + " = '"+valueCondition+"'");
            return dt;
        }
        public static string getStringValueFromBDS(BindingSource bindingSource, string fieldName)
        {
            string result = "";
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                result = drow.Field<string>(fieldName);
            }
            catch (Exception) { }
            return result;
        }
        public static int geIntValueFromBDS(BindingSource bindingSource, string fieldName)
        {
            int result = 0;
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                result = drow.Field<int>(fieldName);
            }
            catch (Exception) { }
            return result;
        }
    }
}
