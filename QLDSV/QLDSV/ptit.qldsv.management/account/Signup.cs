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
                this.initDataForCmbKhoa();
                this.initDataForCmbTeacher();
                cmbRole.DataSource = Program.initLisRole();
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleId";
                if(HelperCommon.PGV != Program.mGroup)
                {
                    cmbRole.Enabled = false;
                }
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
                SqlDataReader myReader = null;
            
                myReader = this.createAccount(accountInfo);
                if (myReader == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi. Không hoàn thành tác vụ!", "", MessageBoxButtons.OK);
                    return;
                }
                myReader.Read();
                if (myReader.GetInt16(0) != 0)
                {
                    MessageBox.Show("Tạo tài khoản không thành công.", "", MessageBoxButtons.OK, MessageBoxIcon.
                        Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            } catch(Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi. Không hoàn thành tác vụ!" + e.StackTrace, "", MessageBoxButtons.OK);
                return;
            }
            
        }
        private SqlDataReader createAccount(AccountInfor accountInfo)
        {
            SqlDataReader myReader = null;

            SqlCommand cmd = new SqlCommand("SP_CREATEANEWACCOUNT", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@LGNAME", accountInfo.Username));
            cmd.Parameters.Add(new SqlParameter("@PASS", accountInfo.Password));
            cmd.Parameters.Add(new SqlParameter("@USERNAME", accountInfo.Magv));
            cmd.Parameters.Add(new SqlParameter("@ROLE", accountInfo.Role));
            myReader = cmd.ExecuteReader();
            return myReader;
        }
        private void initDataForCmbKhoa()
        {
            cmbRole.DataSource = Program.bds_dspm;
            if (cmbRole.DataSource != null)
            {
                cmbRole.DisplayMember = "TENKHOA";
                cmbRole.ValueMember = "TENSERVER";

                cmbRole.SelectedIndex = Program.mKhoa;
            }
            if (HelperCommon.PGV.Equals(Program.mGroup.Trim()))
            {
                cmbRole.Enabled = true;
            }
            else
            {
                cmbRole.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HelperCommon.getListKhoa(cmbRole))
            {
                this.initDataForCmbTeacher();
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
    }
}
