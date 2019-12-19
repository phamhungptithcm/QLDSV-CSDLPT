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

namespace QLDSV.ptit.qldsv.management.student
{
    public partial class Student : DevExpress.XtraEditors.XtraForm
    {
        private StudentService studentService = new StudentService();
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
            // TODO: This line of code loads data into the 'dS_QLDSV.SINHVIEN' table. You can move, or remove it, as needed.

            try
            {
                dS_QLDSV.EnforceConstraints = false;
                this.refreshDataGridViewStudent();
                cmbKhoa.DataSource = Program.bds_dspm;
                if (cmbKhoa.DataSource != null)
                {
                    cmbKhoa.DisplayMember = "TENKHOA";
                    cmbKhoa.ValueMember = "TENSERVER";
                    cmbKhoa.SelectedIndex = Program.mKhoa;
                }
                if ("PGV".Equals(Program.mGroup.Trim()))
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
                this.showGenderOfCurrentStudent();

            }
            catch (Exception) { }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbKhoa.SelectedValue.ToString().Equals(""))
            {
                // cmbKhoa.SelectedIndex = Program.mKhoa;
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
                this.refreshDataGridViewStudent();
            }
        }
        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {
            this.disableInputsEdit();
            this.showGenderOfCurrentStudent();
        }
        private void btnAddNewStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //sINHVIENBindingSource.AddingNew();
        }

        private void btnEditStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // enable edit if this account currently is PGV
            this.enableInputEditByRole();
            
        }

        private void btnDeleteStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                sINHVIENBindingSource.RemoveCurrent();
                notifyDelete.ShowBalloonTip(1500);
            }
        }

        private void btnTransferClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogTransferClass myControl = new DialogTransferClass();
            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, "Sign in", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // do something 
            }
        }

        private void btnSaveStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCancelAction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void accessActionByRole()
        {
            if (!"PGV".Equals(Program.mGroup))
            {
                btnEditStudent.Enabled = false;
                btnAddNewStudent.Enabled = false;
                btnSaveStudent.Enabled = false;
                btnDeleteStudent.Enabled = false;
                btnTransferClass.Enabled = false;
                btnCancelAction.Enabled = false;
            }
            btnCancelAction.Enabled = false;
        }
        private void disableInputsEdit()
        {
            txtMASV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtGhiChu.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtMaLop.Enabled = false;
            txtNoiSinh.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            chkNghiHoc.Enabled = false;
        }
        private void enableInputEditByRole()
        {
            if ("PGV".Equals(Program.mGroup))
            {
                txtMASV.Enabled = true;
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                txtDiaChi.Enabled = true;
                txtGhiChu.Enabled = true;
                txtNgaySinh.Enabled = true;
                txtMaLop.Enabled = true;
                txtNoiSinh.Enabled = true;
                gender.Enabled = true;
                chkNghiHoc.Enabled = true;
            }
        }

        
        private void showGenderOfCurrentStudent()
        {
            bool gender = studentService.getGender(sINHVIENBindingSource);
            rdbNam.Checked = true;
            if (gender == false)
            {
                rdbNu.Checked = true;
            }
        }
        private void refreshDataGridViewStudent()
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
        }
    }
    public class DialogTransferClass : XtraUserControl
    {
        public DialogTransferClass()
        {
            LayoutControl lc = new LayoutControl();
            lc.Dock = DockStyle.Fill;
            TextEdit teLogin = new TextEdit();
            TextEdit tePassword = new TextEdit();
            CheckEdit ceKeep = new CheckEdit() { Text = "Keep me signed in" };
            SeparatorControl separatorControl = new SeparatorControl();
            lc.AddItem(String.Empty, teLogin).TextVisible = false;
            lc.AddItem(String.Empty, tePassword).TextVisible = false;
            lc.AddItem(String.Empty, ceKeep);
            this.Controls.Add(lc);
            this.Height = 100;
            this.Dock = DockStyle.Top;

        }
    }
}