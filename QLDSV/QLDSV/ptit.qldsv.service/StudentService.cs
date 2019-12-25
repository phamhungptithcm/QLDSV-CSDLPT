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
        public string getFullname(BindingSource bindingSource)
        {
            string fullname = "";
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                string ho = drow.Field<string>("HO");
                string ten = drow.Field<string>("TEN");
                fullname = ho + " " + ten;
            }
            catch(Exception) {}
            return fullname;
        }
        public string getClassId(BindingSource bindingSource)
        {
            string classId = "";
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                classId = drow.Field<string>("MALOP");
            }
            catch(Exception){}
            return classId;
        }
        public DateTime getDayOfBirth(BindingSource bindingSource)
        {
            DateTime ngaySinh = new DateTime();
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                ngaySinh = drow.Field<DateTime>("NGAYSINH");
            }
            catch (Exception) { }
            return ngaySinh;
        }
        public string getStudentId(BindingSource bindingSource)
        {
            string maSV = "";
            try
            {
                DataRow drow = HelperCommon.getDataRowFromBindingSource(bindingSource);
                maSV = drow.Field<string>("MASV");
            }
            catch (Exception) { }
            return maSV;
        }
    }
}
