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

namespace QLDSV
{
    public partial class Class : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string makhoa = "";

        public Class()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void Class_Load(object sender, EventArgs e)
        {
            

            try
            {
                dS_QLDSV.EnforceConstraints = false;
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                cmbKHOA.DataSource = Program.bds_dspm;//gán bds cho combobox
                this.LOPTableAdapter.Fill(this.dS_QLDSV.LOP);
            
                this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);

                makhoa = ((DataRowView)bdsLOP[0])["MAKH"].ToString();
                groupBox1.Enabled = false;

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
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRepair.Enabled = false;
                    btnWritethe.Enabled = false;
                    btnExit.Enabled = false;
                    btnRecovery.Enabled = false;
                }

            }
            catch (Exception) { }
     
        }

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e) {

            if (!cmbKHOA.SelectedValue.ToString().Equals("") )
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
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Fill(this.dS_QLDSV.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS_QLDSV.SINHVIEN);

                }
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnWritethe.Enabled = true;
            txtMALOP.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            txtMAKHOA.Enabled = false;
            btnRecovery.Enabled = false;
            btnRepair.Enabled = false;
            vitri = bdsLOP.Position;
            groupBox1.Enabled = true;
            bdsLOP.AddNew();
            txtMAKHOA.Text = makhoa;
            btnAdd.Enabled = btnDelete.Enabled = btnRepair.Enabled = btnRecovery.Enabled = false;

        }

        private void btnWritethe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = false;
            btnWritethe.Enabled = false;
            if (txtTENLOP.Text.Trim() == "" || txtMALOP.Text.Trim() == "")
            {
               
                if (txtTENLOP.Text.Trim() == "")
                {
                    MessageBox.Show("Tên lớp không được trống.!", "", MessageBoxButtons.OK);
                    txtTENLOP.Focus();
                    btnWritethe.Enabled = true;
                    groupBox1.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Mã lớp không được trống.!", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    btnWritethe.Enabled = true;
                    groupBox1.Enabled = true;
                    return;
                }

            }

            try
            {
                bdsLOP.EndEdit();
                bdsLOP.ResetCurrentItem();
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Update(this.dS_QLDSV.LOP);
                MessageBox.Show("Ghi thành công.!", "", MessageBoxButtons.OK);
                btnAdd.Enabled = btnDelete.Enabled = btnRepair.Enabled = btnRecovery.Enabled = true;
                groupBox1.Enabled = false;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ghi lớp.!", "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDelete.Enabled = false;
            if (bds_SINHVIEN.Count > 0)
            {
                MessageBox.Show("Lớp này không thể xóa vì đã có sinh viên.!", "", MessageBoxButtons.OK);
                btnDelete.Enabled = true;
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa lớp không?",
                    "Xác nhận.",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsLOP.RemoveCurrent();
                    this.LOPTableAdapter.Update(this.dS_QLDSV.LOP);
                    MessageBox.Show("Xóa lớp thành công.!", "", MessageBoxButtons.OK);
                    btnDelete.Enabled = true;
                    groupBox1.Enabled = false;
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa lớp thất bại.!", "", MessageBoxButtons.OK);
                    btnDelete.Enabled = true;
                    groupBox1.Enabled = false;
                    return;
                }

            } else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnRepair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMAKHOA.Enabled = false;
            btnAdd.Enabled = false;
            btnRepair.Enabled = false;
            btnDelete.Enabled = false;
            groupBox1.Enabled = true;
            vitri = bdsLOP.Position;

        }

        private void btnRecovery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            bdsLOP.Position = vitri;
            groupBox1.Enabled = false;
         

        }

       
    }
}