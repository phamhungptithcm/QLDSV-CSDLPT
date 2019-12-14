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

namespace QLDSV.ptit.qldsv.management.student
{
    public partial class Student : DevExpress.XtraEditors.XtraForm
    {
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
                cmbKhoa.DataSource = Program.bds_dspm;
                if(cmbKhoa.DataSource != null)  {
                        cmbKhoa.DisplayMember = "TENKHOA";
                        cmbKhoa.ValueMember = "TENSERVER";
                        cmbKhoa.SelectedIndex = Program.mKhoa;
                }
                if ("PGV".Equals(Program.mGroup.Trim())) {
                     cmbKhoa.Enabled = true;
                } else {
                    cmbKhoa.Enabled = false;
                }
            }
            catch (Exception) { }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cmbKhoa.SelectedValue.ToString().Equals("")) {
               // cmbKhoa.SelectedIndex = Program.mKhoa;
                DataRowView drow = (DataRowView)cmbKhoa.SelectedItem;
                String servername = drow.Row.Field<String>("TENSERVER");
                Program.servername = servername;
                }
            if(cmbKhoa.SelectedIndex != Program.mKhoa) {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } else {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            } 
            if(Program.KetNoi() == 0) {

            } else  {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);
            }
        }
    }
}