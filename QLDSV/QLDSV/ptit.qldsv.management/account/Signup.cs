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

namespace QLDSV.ptit.qldsv.management.account
{
    public partial class Signup : DevExpress.XtraEditors.XtraForm
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            BindingSource dsGroupBinding = new BindingSource();
            dsGroupBinding.DataSource = Program.groups;
            cmbGroup.DataSource = dsGroupBinding.DataSource;
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.ValueMember = "GroupId";
            
        }
    }
}