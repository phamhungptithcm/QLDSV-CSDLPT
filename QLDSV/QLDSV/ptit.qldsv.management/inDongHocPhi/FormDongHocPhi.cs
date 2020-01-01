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
using DevExpress.XtraReports.UI;


namespace QLDSV.ptit.qldsv.management.inDongHocPhi
{
    public partial class FormDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public FormDongHocPhi()
        {
            InitializeComponent();
        }

        private void FormDongHocPhi_Load(object sender, EventArgs e)
        {
            try
            {
                Program.conn.Close();
                string connect = "Data Source=JAXZ;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=1234";
                Program.conn.ConnectionString = connect;
                Program.conn.Open();

            }

            catch (Exception a)
            {

                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nHãy kiểm tra lại thông tin kết nối.\n " + a.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MALOP,TENLOP FROM LOP");
            Program.bds_dspm.DataSource = dt;
            cmbTENLOP.DataSource = dt;
            cmbTENLOP.DisplayMember = "TENLOP";
            cmbTENLOP.ValueMember = "MALOP";

            //Combobox NienKhoa
            string currentYear = DateTime.Now.Year.ToString();
            for (int i = -6; i <= 0; i++)
            {
                cmbNIENKHOA.Items.Add((int.Parse(currentYear) + i).ToString());
            }
            cmbNIENKHOA.SelectedIndex = 0;

            //Combobox HocKi
            for (int i = 0; i <= 2; i++)
            {
                cmbHOCKI.Items.Add(i + 1).ToString();
            }
            cmbHOCKI.SelectedIndex = 0;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tenlop = cmbTENLOP.SelectedValue.ToString();
            string nienkhoa = cmbNIENKHOA.SelectedItem.ToString();
            int hocki = int.Parse(cmbHOCKI.SelectedItem.ToString());

            DongHocPhi inds = new DongHocPhi(tenlop, nienkhoa, hocki);
            inds.lblLOP.Text = cmbTENLOP.Text;
            inds.lblNIENKHOA.Text = cmbNIENKHOA.Text;
            inds.lblHOCKI.Text = cmbHOCKI.Text;
            ReportPrintTool print = new ReportPrintTool(inds);
            print.ShowPreviewDialog();

        }
    }
}