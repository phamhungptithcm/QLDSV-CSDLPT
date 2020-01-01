using QLDSV.ptit.qldsv.management.student;
using QLDSV.ptit.qldsv.management.subjects;
using QLDSV.ptit.qldsv.management.scores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDSV.ptit.qldsv.management.account;
using QLDSV.ptit.qldsv.service;
using QLDSV.ptit.qldsv.management.school_fee;
using QLDSV.ptit.qldsv.management.inPhieuDiem;

using QLDSV.ptit.qldsv.management.inDSThiHetMon;
using QLDSV.ptit.qldsv.management.inDSSV;
using QLDSV.ptit.qldsv.management.inBangDiem;
using QLDSV.ptit.qldsv.management.inDongHocPhi;

namespace QLDSV.ptit.qldsv.management.home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnManageStudents_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Student));
            if (f == null)
            {
                Student student = new Student();
                student.MdiParent = this;
                student.Show();
            }
            else
            {
                f.Activate();
            }
        }


        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Class));
            if (frm != null) frm.Activate();
            else
            {
                Class f = new Class();
                f.MdiParent = this;
                f.Show();
            }


        }

        private void btnSubjects_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form s = this.CheckExists(typeof(Subjects));
            if (s != null) s.Activate();
            else
            {
                Subjects f = new Subjects();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnScores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form sco = this.CheckExists(typeof(Scores));
            if (sco != null) sco.Activate();
            else
            {
                Scores f = new Scores();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(Program.mGroup != HelperCommon.PKT)
            {
                btnManageStudents.PerformClick();
                btnDongHocPhi.Enabled = false;
            } else
            {
                btnScores.Enabled = false;
                btnManageStudents.Enabled = false;
                btnClass.Enabled = false;
                btnSubjects.Enabled = false;
                btnDongHocPhi.PerformClick();
            }

            barLblCurrName.Caption = Program.mHoten;
            Program.bds_dspm.RemoveAt(2);
            
        }

        private void btnCreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Signup signup = new Signup();
            try
            {
                signup.ShowDialog();
            }
            catch (Exception) { }
        }

        private void btnDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form schoolFee = this.CheckExists(typeof(SchooFee));
            if (schoolFee != null) schoolFee.Activate();
            else
            {
                SchooFee f = new SchooFee();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Program.mGroup = "";
                Program.mHoten = "";
                Close();
                this.notifySuccess.ShowBalloonTip(1500);
                Application.Restart();
                
            }
            
        }

        private void btnReportHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form inPhieuDiem = this.CheckExists(typeof(FormPhieuDiem));
            if (inPhieuDiem != null) inPhieuDiem.Activate();
            else
            {
                FormPhieuDiem f = new FormPhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSThiHetMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form inDSThiHetMon = this.CheckExists(typeof(FormNhap));
            if (inDSThiHetMon != null) inDSThiHetMon.Activate();
            else
            {
                FormNhap f = new FormNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form inDSSV = this.CheckExists(typeof(FormInput));
            if (inDSSV != null) inDSSV.Activate();
            else
            {
                FormInput f = new FormInput();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form inBangDiem = this.CheckExists(typeof(FormBangDiem));
            if (inBangDiem != null) inBangDiem.Activate();
            else
            {
                FormBangDiem f = new FormBangDiem();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form inDongHocPhi = this.CheckExists(typeof(FormDongHocPhi));
            if (inDongHocPhi != null) inDongHocPhi.Activate();
            else
            {
                FormDongHocPhi f = new FormDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }

        }
    }
}
