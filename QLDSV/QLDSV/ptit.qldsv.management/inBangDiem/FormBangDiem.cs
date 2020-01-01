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

namespace QLDSV.ptit.qldsv.management.inBangDiem
{
    public partial class FormBangDiem : DevExpress.XtraEditors.XtraForm
    {

        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {

            dS_QLDSV.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);
            this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);

            cmbKHOA.DataSource = Program.bds_dspm;

            if (cmbKHOA.DataSource != null)
            {
                cmbKHOA.DisplayMember = "TENKHOA";
                cmbKHOA.ValueMember = "TENSERVER";
                cmbKHOA.SelectedIndex = Program.mKhoa;
            }
            if ("PGV".Equals(Program.mGroup.Trim()))
            {
                cmbKHOA.Enabled = true;
            }
            else
            {
                cmbKHOA.Enabled = false;
            }
            this.cmbLan.SelectedIndex = -1;
            this.cmbLan.SelectedIndex = 0;



        }

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbKHOA.SelectedValue.ToString().Equals(""))
            {
                DataRowView drow = (DataRowView)cmbKHOA.SelectedItem;
                String servername = drow.Row.Field<String>("TENSERVER");
                Program.servername = servername;

                if (cmbKHOA.SelectedIndex != Program.mKhoa)
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

                    try
                    {
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS_QLDSV.LOP);
                        if (cmbTENLOP.Items.Count > 0)
                        {
                            cmbTENLOP.SelectedIndex = -1;
                            cmbTENLOP.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }



            }
        }

        private void cmbTENLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? seletedLop = cmbTENLOP.SelectedIndex;
            int? seletedMonHoc = cmbTENMONHOC.SelectedIndex;
            if (seletedLop != null && seletedLop != -1 && seletedMonHoc != null && seletedMonHoc != -1)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tl = cmbTENLOP.Text;
            string tmh = cmbTENMONHOC.Text;
            short lan = short.Parse(cmbLan.Text);
            InBangDiemHetMon inbd = new InBangDiemHetMon(tl,tmh,lan);
            inbd.lblLop.Text = cmbTENLOP.Text;
            inbd.lblMonHoc.Text = cmbTENMONHOC.Text;
            inbd.lblLanthi.Text = cmbLan.Text;
            ReportPrintTool print = new ReportPrintTool(inbd);
            print.ShowPreviewDialog();
        }
    }
}