using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Diagnostics;
using QLDSV.ptit.qldsv.service;
using DevExpress.XtraGrid.Views.Base;

namespace QLDSV.ptit.qldsv.management.school_fee
{
    public partial class SchoolFee : DevExpress.XtraEditors.XtraForm
    {
        private bool actionType = true; // 0: Update; 1: Insert
        private StudentService studentService = new StudentService();
        public SchoolFee()
        {
            InitializeComponent();
        }

        private void SchoolFee_Load(object sender, EventArgs e)
        {
            grbStudentInfor.Visible = false;
            grdDongHocPhi.Visible = false;
            dS_QLDSV.EnforceConstraints = false;
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.excuteGetListStudent();
            
        }
        private void excuteGetListStudent()
        {
            try
            {
                string maSV = txtMaSV.Text;
                DataTable dt = HelperCommon.queryDataByOneCondition("SINHVIEN", "MASV", maSV);
                BindingSource bdsStudent = new BindingSource();
                bdsStudent.DataSource = dt;
                lblMaSV.Text = studentService.getStudentId(bdsStudent);
                lblFullname.Text = studentService.getFullname(bdsStudent);
                lblDayOfBirth.Text = studentService.getDayOfBirth(bdsStudent).ToString();
                lblGender.Text = studentService.getGender(bdsStudent) == true ? "Nam" : "Nữ";
                lblClass.Text = studentService.getClassId(bdsStudent);
                String strLenh =
                 "EXEC dbo.sp_GetHocPhi @MASV = '" + maSV + "'";
                DataTable myTable = Program.ExecSqlDataTable(strLenh);

                grdDongHocPhi.DataSource = myTable;

                ColumnView columView = grdDongHocPhi.FocusedView as ColumnView;
                int rowCount = columView.RowCount;
                if (rowCount > 0)
                {
                    grbStudentInfor.Visible = true;
                    grdDongHocPhi.Visible = true;
                } else
                {
                    MessageBox.Show("Mã " + maSV + " không tồn tại.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.StackTrace);
            }
            
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView columView = grdDongHocPhi.FocusedView as ColumnView;
            int rowCount = columView.RowCount;
            
            string strLenh = "";
            
            for (int i = 0; i < rowCount; i++)
            {
                if (actionType == true)
                    strLenh = "INSERT INTO [dbo].[HOCPHI] ([MASV],[NIENKHOA],[HOCKY],[HOCPHI],[SOTIENDADONG]) VALUES (@MASV , @NIENKHOA, @HOCKY , @HOCPHI , @SOTIENDADONG)";
                else
                {
                    strLenh = "UPDATE [dbo].[HOCPHI] SET [MASV] = @MASV, [NIENKHOA] =  @NIENKHOA,[HOCKY] = @HOCKY,[HOCPHI] = @HOCPHI,[SOTIENDADONG] = @SOTIENDADONG WHERE  ";
                }
                using (SqlConnection sqlConn = new SqlConnection(Program.connstr))
                using (SqlCommand sqlcmd = new SqlCommand(strLenh, sqlConn))
                {
                    //sqlcmd.Parameters.AddWithValue("@MASV", columView.GetRowCellValue(i, "MASV").ToString().Trim());
                    //sqlcmd.Parameters.AddWithValue("@MAMH", cmbSubject.SelectedValue.ToString());
                    //sqlcmd.Parameters.AddWithValue("@LAN", int.Parse(cmbLanThi.SelectedItem.ToString()));
                    //sqlcmd.Parameters.AddWithValue("@DIEM", float.Parse(columView.GetRowCellValue(i, "DIEM").ToString().Trim()));
                    sqlConn.Open();
                    try
                    {
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(ex.StackTrace);
                        sqlConn.Close();
                        return;
                    }
                    sqlConn.Close();
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.excuteGetListStudent();
            }
        }
    }
}