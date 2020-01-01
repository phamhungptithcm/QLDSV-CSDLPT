using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.ptit.qldsv.management.inDSSV
{
    public partial class FormReport : DevExpress.XtraReports.UI.XtraReport
    {
        public FormReport(string malop)
        {
            InitializeComponent();
            this.dS_QLDSV1.EnforceConstraints = false;
            this.sP_INDSSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INDSSINHVIENTableAdapter.Fill(dS_QLDSV1.SP_INDSSINHVIEN, malop);

        }

    }
}
