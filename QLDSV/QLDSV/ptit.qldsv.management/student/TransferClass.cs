using QLDSV.ptit.qldsv.model;
using QLDSV.ptit.qldsv.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.ptit.qldsv.management.student
{
    public partial class TransferClass : Form
    {

        public TransferClass()
        {
            InitializeComponent();
        }

        private void TransferClass_Load(object sender, EventArgs e)
        {
            
            cmbKhoaFormChuyenLop.DataSource = Program.bds_dspm;
            if (cmbKhoaFormChuyenLop.DataSource != null)
            {
                cmbKhoaFormChuyenLop.DisplayMember = "TENKHOA";
                cmbKhoaFormChuyenLop.ValueMember = "TENSERVER";

                cmbKhoaFormChuyenLop.SelectedIndex = Program.mKhoa;
            }
            this.initDataForCmbClass();
            this.initStudentInfo();
        }

        private void initStudentInfo()
        {
            lblClassId.Text = Program.curStudent.ClassId;
            lblStudentId.Text = Program.curStudent.StudentId;
            lblName.Text = Program.curStudent.Fullname;
            lblDayOfBirth.Text = Program.curStudent.BirthDay.ToString();
        }
        private void initDataForCmbClass()
        {
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM LOP");
            cmbClass.DataSource = dt;
            cmbClass.DisplayMember = "TENLOP";
            cmbClass.ValueMember = "MALOP";
            cmbClass.SelectedIndex = 0;
        }
        
        private void cmbKhoaFormChuyenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HelperCommon.getListKhoa(cmbKhoaFormChuyenLop))
            {
                this.initDataForCmbClass();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

            } catch(Exception)
            {
                this.notifyFail.ShowBalloonTip(1500);
            }
        }
    }
}
