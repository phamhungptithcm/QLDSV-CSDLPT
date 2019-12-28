using QLDSV.ptit.qldsv.model;
using QLDSV.ptit.qldsv.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            HelperCommon.initDataCmbFromDB(cmbClass, "LOP", "TENLOP", "MALOP");
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
            string maLop = "";
            if (!cmbClass.SelectedValue.ToString().Equals(""))
            {
                DataRowView drow = (DataRowView)cmbClass.SelectedItem;
                maLop = drow.Row.Field<String>("MALOP");
            }
            SqlDataReader myReader = null;
            string sql = "SP_CHUYENLOP '" + Program.curStudent.StudentId + "','" + maLop+ "'";
            try
            {
                myReader = Program.ExecSqlDataReader(sql);
                if (myReader == null)
                {
                    this.notifyFail.ShowBalloonTip(1500);
                    return;
                }
                myReader.Read();
                this.notifySuccess.ShowBalloonTip(1500);
                this.Close();
            } catch(Exception ex)
            {
                Debug.Print(ex.StackTrace);
                this.notifyFail.ShowBalloonTip(1500);
                return;
            }
        }
    }
}
