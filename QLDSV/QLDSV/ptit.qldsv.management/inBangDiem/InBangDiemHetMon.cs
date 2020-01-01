using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.ptit.qldsv.management.inBangDiem
{
    public partial class InBangDiemHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public InBangDiemHetMon(string tenlop,string tenmonhoc,short lan)
        {
            InitializeComponent();
            this.dS_QLDSV1.EnforceConstraints = false;
            this.sP_INBANGDIEMMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBANGDIEMMONHOCTableAdapter.Fill(dS_QLDSV1.SP_INBANGDIEMMONHOC, tenlop, tenmonhoc, lan);

        }

    }
}
