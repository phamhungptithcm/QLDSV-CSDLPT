using QLDSV.ptit.qldsv.management.account;
using QLDSV.ptit.qldsv.management.student;
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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Signup));
            if (f == null)
            {
                Signup signup = new Signup();
                signup.MdiParent = this;
                signup.Show();
            }
            else
            {
                f.Activate();
            }
        }
    }
}
