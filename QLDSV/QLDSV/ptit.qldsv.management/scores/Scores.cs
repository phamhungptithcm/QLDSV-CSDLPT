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

namespace QLDSV.ptit.qldsv.management.scores
{
    public partial class Scores : DevExpress.XtraEditors.XtraForm
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HelperCommon.getListKhoa(cmbKhoa))
            {
                this.initDataForCmbClass();
            }
        }
        private void initDataForCmbClass()
        {
            HelperCommon.initDataCmbFromDB(cmbClass, "LOP", "TENLOP", "MALOP");
        }
        private void initCmbLanThi()
        {
            for(int i = 1; i < 3; i++)
            {
                cmbLanThi.Items.Add(i);
            }
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dspm;
            if (cmbKhoa.DataSource != null)
            {
                cmbKhoa.DisplayMember = "TENKHOA";
                cmbKhoa.ValueMember = "TENSERVER";

                cmbKhoa.SelectedIndex = Program.mKhoa;
            }
            this.initCmbLanThi();
            this.initDataForCmbClass();
        }
    }
}