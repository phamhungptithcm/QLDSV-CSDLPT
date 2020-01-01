using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.ptit.qldsv.management.inPhieuDiem
{
    public partial class ReportPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPhieuDiem(string masv)
        {
            InitializeComponent();
            this.dS_QLDSV1.EnforceConstraints = false;
            this.sP_PHIEUDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_PHIEUDIEMTableAdapter.Fill(dS_QLDSV1.SP_PHIEUDIEM, masv);
        }

    }
}
