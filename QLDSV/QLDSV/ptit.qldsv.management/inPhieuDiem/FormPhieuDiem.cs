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

namespace QLDSV.ptit.qldsv.management.inPhieuDiem
{
    public partial class FormPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuDiem()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void Form_Load(object sender, EventArgs e)
        {
            dS_QLDSV.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);

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
           
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbKhoa.SelectedValue.ToString().Equals(""))
            {
                DataRowView drow = (DataRowView)cmbKhoa.SelectedItem;
                String servername = drow.Row.Field<String>("TENSERVER");
                Program.servername = servername;

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
                    MessageBox.Show("That bai.!", "", MessageBoxButtons.OK);
                }
                else
                {
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msv = cmbMSV.Text;
            ReportPhieuDiem pd = new ReportPhieuDiem(msv);
            pd.lbMSV.Text = msv;
            ReportPrintTool print = new ReportPrintTool(pd);
            print.ShowPreviewDialog();

        }
    }
}