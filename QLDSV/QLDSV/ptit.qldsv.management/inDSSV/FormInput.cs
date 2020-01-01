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

namespace QLDSV.ptit.qldsv.management.inDSSV
{
    public partial class FormInput : DevExpress.XtraEditors.XtraForm
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            this.dS_QLDSV.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);
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
            } else
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);

                }
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormReport rb = new FormReport(cmbTenLop.SelectedValue.ToString());
            rb.lblKhoa.Text = cmbKhoa.Text;
            rb.lblLop.Text = cmbTenLop.SelectedValue.ToString();
            ReportPrintTool print = new ReportPrintTool(rb);
            print.ShowPreviewDialog();

        }
    }
}