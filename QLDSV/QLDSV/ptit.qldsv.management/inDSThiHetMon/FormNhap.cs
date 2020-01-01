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

namespace QLDSV.ptit.qldsv.management.inDSThiHetMon
{
    public partial class FormNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormNhap()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void FormNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLDSV.DIEM' table. You can move, or remove it, as needed.
           

            dS_QLDSV.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
           
            this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
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
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            cmbLan.SelectedIndex = 0;
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
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;              
                    this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
                    this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string tl = cmbTenLop.Text;
            string tmh = cmbTenmh.Text;
            short l = short.Parse(cmbLan.Text);
            ReportDSThiHetMon hm = new ReportDSThiHetMon(tl,tmh, l);
            hm.lbllop.Text = tl;
            hm.lblmonhoc.Text = tmh;
            ReportPrintTool print = new ReportPrintTool(hm);
            print.ShowPreviewDialog();
        }
    }
}