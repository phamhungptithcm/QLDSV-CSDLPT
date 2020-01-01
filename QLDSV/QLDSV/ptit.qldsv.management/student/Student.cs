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
using DevExpress.XtraLayout;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace QLDSV.ptit.qldsv.management.student
{
    public partial class Student : DevExpress.XtraEditors.XtraForm
    {
        private StudentService studentService = new StudentService();
        private int lastPosition = 0;
        private bool acctionType = false; // true = AddNew; false = Edit
        public Student()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void Student_Load(object sender, EventArgs e)
        {
            dS_QLDSV.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_QLDSV.SINHVIEN' table. You can move, or remove it, as needed.
            try
            {
                dS_QLDSV.EnforceConstraints = false;
                this.refreshDataGridViewStudent();
                //Program.bds_dspm.RemoveAt(2);
                cmbKhoa.DataSource = Program.bds_dspm;
                if (cmbKhoa.DataSource != null)
                {
                    cmbKhoa.DisplayMember = "TENKHOA";
                    cmbKhoa.ValueMember = "TENSERVER";
                    
                    cmbKhoa.SelectedIndex = Program.mKhoa;
                }
                if (HelperCommon.PGV.Equals(Program.mGroup.Trim()))
                {
                    cmbKhoa.Enabled = true;
                }
                else
                {
                    cmbKhoa.Enabled = false;
                }
                // Check current account has role to handle actions in student management page
                this.accessActionByRole();
                // Disable form edit
                this.disableInputsEdit();
                resetViewGender();

            }
            catch (Exception) { }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HelperCommon.getListKhoa(cmbKhoa)) {
                this.refreshDataGridViewStudent();
            }
        }
        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {
            this.disableInputsEdit();
            this.resetViewGender();
        }
        private void btnAddNewStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.acctionType = true;
            txtMASV.Focus();
            this.initDataForCmbClass();
            this.enableInputEditByRole();
            this.blockWhenHasAction();
            sINHVIENBindingSource.AddNew();
            sINHVIENBindingSource.MoveLast();
            lastPosition = sINHVIENBindingSource.Position;
        }

        private void btnEditStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // enable edit if this account currently is PGV
            this.acctionType = false;
            this.enableInputEditByRole();
            this.blockWhenHasAction();
            this.lastPosition = sINHVIENBindingSource.Position;
        }

        private void btnDeleteStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    sINHVIENBindingSource.RemoveCurrent();
                    sINHVIENBindingSource.MoveFirst();
                    this.notifySuccess.ShowBalloonTip(1500);
                } catch (Exception) {
                    this.notifyFail.ShowBalloonTip(1500);
                }
                
            }
        }

        private void btnTransferClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.curStudent.StudentId = studentService.getStudentId(this.sINHVIENBindingSource);
            Program.curStudent.ClassId = studentService.getClassId(this.sINHVIENBindingSource);
            Program.curStudent.BirthDay = studentService.getDayOfBirth(this.sINHVIENBindingSource);
            Program.curStudent.Fullname = studentService.getFullname(this.sINHVIENBindingSource);
            TransferClass transferClass = new TransferClass();
            try
            {
                int position = cmbKhoa.SelectedIndex;
                cmbKhoa.Visible = false;
                grbStudentInfor.Visible = false;
                sINHVIENGridControl.Visible = false;
                transferClass.ShowDialog();
                cmbKhoa.SelectedIndex = position;
                Program.servername = cmbKhoa.SelectedValue.ToString();
                sINHVIENGridControl.Visible = true;
                grbStudentInfor.Visible = true;
                cmbKhoa.Visible = true;
            }
            catch (Exception) { }
        }

        private void btnSaveStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (this.validateFormStudent())
                {

                    sINHVIENBindingSource.EndEdit();
                    sINHVIENBindingSource.ResetCurrentItem();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS_QLDSV.SINHVIEN);
                    sINHVIENBindingSource.Position = lastPosition;
                    this.acctionType = false;
                    this.accessActionByRole();
                    this.disableInputsEdit();
                    txtMaLop.Visible = true;
                    this.notifySuccess.ShowBalloonTip(1500);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.StackTrace);
                this.notifyFail.ShowBalloonTip(1500);
                return;
            }
            
        }

        private void btnCancelAction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                sINHVIENBindingSource.CancelEdit();
                this.refreshDataGridViewStudent();
                this.accessActionByRole();
                this.disableInputsEdit();
            }
        }
        private void accessActionByRole()
        {
            if (!HelperCommon.PGV.Equals(Program.mGroup))
            {
                btnEditStudent.Enabled = false;
                btnAddNewStudent.Enabled = false;
               
                btnDeleteStudent.Enabled = false;
                btnTransferClass.Enabled = false;
                btnCancelAction.Enabled = false;
                cmbKhoa.Enabled = false;
            } else
            {
                btnEditStudent.Enabled = true;
                btnAddNewStudent.Enabled = true;
                btnDeleteStudent.Enabled = true;
                btnTransferClass.Enabled = true;
                btnCancelAction.Enabled = true;
                cmbKhoa.Enabled = true;
            }
            btnCancelAction.Enabled = false;
            btnSaveStudent.Enabled = false;
        }
        private void blockWhenHasAction()
        {
            btnEditStudent.Enabled = false;
            btnAddNewStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
            btnTransferClass.Enabled = false;
            cmbKhoa.Enabled = false;
            btnSaveStudent.Enabled = true;
            btnCancelAction.Enabled = true;
        }
        private void disableInputsEdit()
        {
            cmbClass.Visible = false;
            txtMASV.Enabled = false;
            cmbClass.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtGhiChu.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtMaLop.Enabled = false;
            txtNoiSinh.Enabled = false;
            //rdbNam.Enabled = false;
            //rdbNu.Enabled = false;
            ckbGender.Enabled = false;
            chkNghiHoc.Enabled = false;
        }
        private void enableInputEditByRole()
        {
            if (HelperCommon.PGV.Equals(Program.mGroup))
            {
                txtMaLop.Visible = !acctionType;
                cmbClass.Visible = acctionType;
                cmbClass.Enabled = acctionType;
                txtMASV.Enabled = acctionType;
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                txtDiaChi.Enabled = true;
                txtGhiChu.Enabled = true;
                txtNgaySinh.Enabled = true;
                txtMaLop.Enabled = false;
                txtNoiSinh.Enabled = true;
                ckbGender.Enabled = true;
                //rdbNam.Enabled = true;
                //rdbNu.Enabled = true;
                chkNghiHoc.Enabled = true;
            }
        }
        
        private void refreshDataGridViewStudent()
        {
            if(Program.servername != "JAXZ\\SERVER3")
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
            }
            
        }
        private bool validateFormStudent()
        {
            bool validated = true;
            string masv = txtMASV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string noiSinh = txtNoiSinh.Text;
            DateTime ngaySinh = txtNgaySinh.DateTime;
            if(masv.Trim() == "" || masv == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validated = false;
            } else
            {
                if(!checkMaSValid(masv))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    validated = false;
                }
            }
            if (ho.Trim() == "" || ho == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validated = false;
            }
            if (ten.Trim() == "" || ten == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validated = false;
            }
            if (diaChi.Trim() == "" || diaChi == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validated = false;
            }
            if (noiSinh.Trim() == "" || noiSinh == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validated = false;
            }
            if (ngaySinh == null)
            {
                MessageBox.Show("Mã sinh viên không được để trống.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validated = false;
            }

            return validated;
        }
        private void initDataForCmbClass()
        {
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM LOP");
            cmbClass.DataSource = dt;
            cmbClass.DisplayMember = "TENLOP";
            cmbClass.ValueMember = "MALOP";
            cmbClass.SelectedIndex = 0;
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbClass.SelectedValue.ToString().Equals(""))
            {
                DataRowView drow = (DataRowView)cmbClass.SelectedItem;
                String maLop = drow.Row.Field<String>("MALOP");
                txtMaLop.Text = maLop;
            }
        }

        private void ckbGender_CheckedChanged(object sender, EventArgs e)
        {
            resetViewGender();
        }
        private void resetViewGender()
        {
            if (ckbGender.Checked == true)
            {
                ckbGender.Text = "Nam";
            }
            else
            {
                ckbGender.Text = "Nữ";
            }
        }
        
        private bool checkMaSValid(string maSV)
        {
            bool result = true;
            string strLenh = "EXEC SP_KIEMTRAMASINHVIEN @MASV = '" + maSV + "'";
            SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader != null && myReader.HasRows)
            {
                result = false;
            } else
            {
                int oldIndex = cmbKhoa.SelectedIndex;
                if (oldIndex == 0)
                {
                    cmbKhoa.SelectedIndex = 1;
                    Program.servername = cmbKhoa.SelectedValue.ToString();
                }
                else
                {
                    cmbKhoa.SelectedIndex = 0;
                    Program.servername = cmbKhoa.SelectedValue.ToString();
                }
                if (cmbKhoa.SelectedIndex != oldIndex)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader != null && myReader.HasRows)
                {
                    result = false;
                }
                cmbKhoa.SelectedIndex = oldIndex;
            }
            return result;
        }
    }
}