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
using QLDSV.ptit.qldsv.service;

namespace QLDSV.ptit.qldsv.management.subjects
{
    public partial class Subjects : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;

        public Subjects()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_MONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS_QLDSV.MONHOC);

                if (!HelperCommon.PGV.Equals(Program.mGroup.Trim()))
                {
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRepair.Enabled = false;
                    btnWritethe.Enabled = false;
                    btnExit.Enabled = false;
                    btnRecovery.Enabled = false;
                    groupBox2.Enabled = false;
                }

            } catch(Exception)
            {

            }
           

        }

    
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnWritethe.Enabled = true;
            txtMAMH.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnRecovery.Enabled = false;
            btnRepair.Enabled = false;
            vitri = bds_MONHOC.Position;
            groupBox2.Enabled = true;
            bds_MONHOC.AddNew();
            btnAdd.Enabled = btnDelete.Enabled = btnRepair.Enabled = btnRecovery.Enabled = false;
        }

        private void btnWritethe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            groupBox2.Enabled = false;
            btnWritethe.Enabled = false;
            if (txtMAMH.Text.Trim() == "" || txtTENMH.Text.Trim() == "")
            {

                if (txtMAMH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã Môn học không được trống.!", "", MessageBoxButtons.OK);
                    txtMAMH.Focus();
                    btnWritethe.Enabled = true;
                    groupBox2.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Tên Môn học không được trống.!", "", MessageBoxButtons.OK);
                    txtTENMH.Focus();
                    btnWritethe.Enabled = true;
                    groupBox2.Enabled = true;
                    return;
                }

            }

            try
            {
                bds_MONHOC.EndEdit();
                bds_MONHOC.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS_QLDSV.MONHOC);
                MessageBox.Show("Ghi thành công.!", "", MessageBoxButtons.OK);
                btnAdd.Enabled = btnDelete.Enabled = btnRepair.Enabled = btnRecovery.Enabled = true;
                groupBox2.Enabled = false;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ghi môn học.!", "", MessageBoxButtons.OK);
                return;
            }


        }

        private void btnRepair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMAMH.Enabled = false;
            btnAdd.Enabled = false;
            btnRepair.Enabled = false;
            btnDelete.Enabled = false;
            groupBox2.Enabled = true;
            vitri = bds_MONHOC.Position;
        }

        private void btnRecovery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_MONHOC.CancelEdit();
            bds_MONHOC.Position = vitri;
            groupBox2.Enabled = false;
        }
        
    }
}