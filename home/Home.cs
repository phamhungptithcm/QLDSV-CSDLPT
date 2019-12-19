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

<<<<<<< HEAD
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
=======
        private void Home_Load(object sender, EventArgs e)
        {
            barLblCurrName.Caption = Program.mHoten;
        }
        
>>>>>>> 532db72135b2aac592c129c7a323d8ecffbc0e93
    }
}
