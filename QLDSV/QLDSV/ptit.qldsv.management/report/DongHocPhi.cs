using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.ptit.qldsv.management.report
{
    public partial class DongHocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public DongHocPhi(string tenlop, string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.dS_QLDSV1.EnforceConstraints = false;
            this.sP_INDSDONGHOCPHITableAdapter.Fill(dS_QLDSV1.SP_INDSDONGHOCPHI, tenlop, nienkhoa, hocky);
        }

    }
}
