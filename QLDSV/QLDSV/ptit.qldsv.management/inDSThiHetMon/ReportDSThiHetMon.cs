using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.ptit.qldsv.management.inDSThiHetMon
{
    public partial class ReportDSThiHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSThiHetMon(string tenlop,string monhoc,short lan)
        {
            InitializeComponent();
            this.dS_QLDSV1.EnforceConstraints = false;
            this.sP_INDSTHIHETMONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INDSTHIHETMONTableAdapter.Fill(dS_QLDSV1.SP_INDSTHIHETMON,tenlop,monhoc,lan);
        }

    }
}
