using DevExpress.XtraEditors.Controls;
using QLDSV.ptit.qldsv.model;
using QLDSV.ptit.qldsv.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.ptit.qldsv.management.account
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.initDataForCmbTeacher();
                cmbRole.DataSource = Program.initLisRole();
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleId";
                continueActionByRole();
            }
            catch (Exception) { }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPass.Text;
                string confirmPass = txtConfPass.Text;
                string magv = "";
                string role = "";
                if (username.Trim() == "" || password.Trim() == "")
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác.", "", MessageBoxButtons.OK, MessageBoxIcon.
                        Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                if(confirmPass.Trim() != password.Trim())
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp.", "", MessageBoxButtons.OK, MessageBoxIcon.
                        Warning, MessageBoxDefaultButton.Button1);
                    txtConfPass.Text = "";
                    return;
                }
                if (!cmbTeacher.SelectedValue.ToString().Equals(""))
                {
                    DataRowView drow = (DataRowView)cmbTeacher.SelectedItem;
                    magv = drow.Row.Field<String>("MAGV");
                }
                if (!cmbTeacher.SelectedValue.ToString().Equals(""))
                {
                    Role roleSelected = (Role)cmbRole.SelectedItem;
                    role = roleSelected.RoleId;
                }
                AccountInfor accountInfo = new AccountInfor();
                accountInfo.Username = username.Trim();
                accountInfo.Password = password.Trim();
                accountInfo.Magv = magv.Trim();
                accountInfo.Role = role.Trim();
                string sql = "EXEC dbo.SP_CREATEANEWACCOUNT '" + username+"','" +password+ "','"+magv+"','"+role+"'";
                SqlDataReader myReader = null;
            
                myReader = Program.ExecSqlDataReader(sql);
                if (myReader == null)
                {
                    this.notifyFail.ShowBalloonTip(1500);
                    return;
                }
                myReader.Read();
                this.notifySuccess.ShowBalloonTip(1500);
                this.Close();
            } catch(Exception ex)
            {
                Debug.Print(ex.StackTrace);
                this.notifySuccess.ShowBalloonTip(1500);
                //this.notifyFail.ShowBalloonTip(1500);
                //return;
            }
            
        }
        private void initDataForCmbTeacher()
        {
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM GIANGVIEN");
            cmbTeacher.DataSource = dt;
            cmbTeacher.DisplayMember = "TEN";
            cmbTeacher.ValueMember = "MAGV";
            cmbTeacher.SelectedIndex = 0;
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void continueActionByRole()
        {
            int rolePositon = 0;
            if(Program.mGroup != HelperCommon.PGV)
            {
                switch(Program.mGroup)
                {
                    case HelperCommon.PKT:
                        rolePositon = 2;
                        break;
                    case HelperCommon.KHOA:
                        rolePositon = 1;
                        break;
                    default:
                        rolePositon = 0;
                        break;
                }
                cmbRole.SelectedIndex = rolePositon;
                cmbRole.Enabled = false;
            }
            
        }
        
    }
}
