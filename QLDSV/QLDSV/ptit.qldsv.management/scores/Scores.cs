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
using QLDSV.ptit.qldsv.service;
using System.Diagnostics;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace QLDSV.ptit.qldsv.management.scores
{
    public partial class Scores : DevExpress.XtraEditors.XtraForm
    {
        public Scores()
        {
            InitializeComponent();
        }
        bool actionTyoe = true; // 0: Update; 1: Insert
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HelperCommon.getListKhoa(cmbKhoa))
            {
                this.initDataForCmbClass();
            }
        }
        private void initDataForCmbClass()
        {
            HelperCommon.initDataCmbFromDB(cmbClass, "LOP", "TENLOP", "MALOP");
        }
        private void initCmbLanThi()
        {
            for(int i = 1; i < 3; i++)
            {
                cmbLanThi.Items.Add(i);
            }
            cmbLanThi.SelectedIndex = 0;
        }
        private void initDataForCmbSubject()
        {
            HelperCommon.initDataCmbFromDB(cmbSubject, "MONHOC", "TENMH", "MAMH");
        }
        private void Scores_Load(object sender, EventArgs e)
        {
            GridView grvNhapDiem = sender as GridView;
            dS_QLDSV.EnforceConstraints = false;
            cmbKhoa.DataSource = Program.bds_dspm;
            if (cmbKhoa.DataSource != null)
            {
                cmbKhoa.DisplayMember = "TENKHOA";
                cmbKhoa.ValueMember = "TENSERVER";

                cmbKhoa.SelectedIndex = Program.mKhoa;
            }
            this.initCmbLanThi();
            this.initDataForCmbClass();
            this.initDataForCmbSubject();
            //this.excuteGetListStudent();
            if(Program.mGroup != HelperCommon.PGV)
            {
                cmbKhoa.Enabled = false;
            }
            grdNhapDiem.Visible = false;
        }

        private void btnFilterSinhVien_Click(object sender, EventArgs e)
        {
            this.excuteGetListStudent();
            ColumnView columView = grdNhapDiem.FocusedView as ColumnView;
            int rowCount = columView.RowCount;
            if(rowCount > 0)
            {
               grdNhapDiem.Visible = true;
            } else
            {
                MessageBox.Show("Lớp " + cmbClass.SelectedText+" chưa có sinh viên.", "", MessageBoxButtons.OK);
            }
           
        }
        private void excuteGetListStudent()
        {

            try
            {
                string maLop = cmbClass.SelectedValue.ToString();
                string maMonHoc = cmbSubject.SelectedValue.ToString();
                int lanThi = int.Parse(cmbLanThi.SelectedItem.ToString());

                String strLenhKiemTraNhapDiem =
                "EXEC  dbo.SP_KIEMTRANHAPDIEM " +
                "@MALOP = '" + maLop + "', " +
                "@MAMH = '" + maMonHoc + "', " +
                "@LAN = " + lanThi;

                String strLenh =
                 "EXEC dbo.sp_GetValueDiem @MALOP = '" + maLop + "'," +
                 "@MAMH = '" + maMonHoc + "'," +
                 "@LAN =" + lanThi;

                SqlDataReader myReaderCheckNhapDiem = Program.ExecSqlDataReader(strLenhKiemTraNhapDiem);
                
                if (myReaderCheckNhapDiem != null && myReaderCheckNhapDiem.HasRows)
                {
                    actionTyoe = false;
                }
                myReaderCheckNhapDiem.Close();

                DataTable myTable = Program.ExecSqlDataTable(strLenh);

                grdNhapDiem.DataSource = myTable;
            } catch(Exception ex)
            {
                Debug.Print(ex.StackTrace);
            }
           
            
        }

        private void btnSaveScore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView columView = grdNhapDiem.FocusedView as ColumnView;
            int rowCount = columView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                try
                {
                    float diem = float.Parse(columView.GetRowCellValue(i, "DIEM").ToString().Trim());
                    if (columView.GetRowCellValue(i, "DIEM").ToString().Trim() == "")
                    {
                        MessageBox.Show("Chưa nhập điểm cho sinh viên." +
                            "\nMã sinh viên: " + columView.GetRowCellValue(i, "MASV").ToString().Trim() +
                            "\nDòng: " + i + 1, "", MessageBoxButtons.OK);
                        columView.FocusedRowHandle = i;
                        return;
                    }
                    if (diem > 10 || diem < 0)
                    {
                        MessageBox.Show("Dữ liệu điểm không chính xác. 0 <= ĐIỂM <= 10" +
                            "\nMã sinh viên: " + columView.GetRowCellValue(i, "MASV").ToString().Trim() +
                            "\nDòng: " + i + 1, "", MessageBoxButtons.OK);
                        columView.FocusedRowHandle = i;
                        return;
                    }
                } catch (Exception)
                {
                   
                }
                
                
            }
            string strLenh = "";

            for (int i = 0; i < rowCount; i++)
            {
                try
                {
                    string maSV = columView.GetRowCellValue(i, "MASV").ToString().Trim();
                    string maMH = cmbSubject.SelectedValue.ToString();
                    int lanThi = int.Parse(cmbLanThi.SelectedItem.ToString());
                    float diem = float.Parse(columView.GetRowCellValue(i, "DIEM").ToString().Trim());
                    if (actionTyoe == true)
                        strLenh = "INSERT INTO dbo.DIEM (MASV,MAMH,LAN,DIEM) VALUES (@MASV,@MAMH,@LAN,@DIEM)";
                    else
                    {
                        strLenh = "UPDATE dbo.DIEM SET DIEM = @DIEM WHERE MASV = @MASV and MAMH = @MAMH and LAN = @LAN";
                    }
                    using (SqlConnection sqlConn = new SqlConnection(Program.connstr))
                    using (SqlCommand sqlcmd = new SqlCommand(strLenh, sqlConn))
                    {
                        sqlcmd.Parameters.AddWithValue("@MASV", maSV);
                        sqlcmd.Parameters.AddWithValue("@MAMH", maMH);
                        sqlcmd.Parameters.AddWithValue("@LAN", lanThi);
                        sqlcmd.Parameters.AddWithValue("@DIEM", diem);
                        sqlConn.Open();
                        try
                        {
                            sqlcmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Debug.Print(ex.StackTrace);
                            notifyFail.ShowBalloonTip(1500);
                            sqlConn.Close();
                            return;
                        }
                        sqlConn.Close();
                        notifySuccess.ShowBalloonTip(1500);
                    }
                } catch(Exception)
                {
                    notifyFail.ShowBalloonTip(1500);
                }
                
            }
            
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.excuteGetListStudent();
            }
        }
    }
}