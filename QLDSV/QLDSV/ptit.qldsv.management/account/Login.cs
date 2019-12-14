using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_MAIN.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_MAIN.V_DS_PHANMANH);
            string connectionString = "Data Source=JAXZ;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=1234";
            Program.conn.ConnectionString = connectionString;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = dt;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = 0;
        }


        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác.", "", MessageBoxButtons.OK, MessageBoxIcon.
                    Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            Program.mlogin = txtUsername.Text; Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0) return;

            Program.mKhoa = cmbKhoa.SelectedIndex;
           // Program.bds_dspm = dspmBinding;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP'" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            if (Program.checkLogin())
            {
                Close();
            }
            Program.myReader.Close();
            Program.conn.Close();
            //DialogResult dialog = MessageBox.Show("Giáo Viên: " + Program.mHoten + "\t-\tKhoa: " + Program.mGroup, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception) { };
        }

    }
}
