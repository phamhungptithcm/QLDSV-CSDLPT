namespace QLDSV.ptit.qldsv.management.home
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnReportStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnManageStudents = new DevExpress.XtraBars.BarButtonItem();
            this.btnClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubjects = new DevExpress.XtraBars.BarButtonItem();
            this.btnScores = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongHP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barLblCurrName = new DevExpress.XtraBars.BarStaticItem();
            this.btnDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSignOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSThiHetMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDHP = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraHome = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.notifySuccess = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraHome)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnReportStudent,
            this.btnManageStudents,
            this.btnClass,
            this.btnSubjects,
            this.btnScores,
            this.btnDongHP,
            this.barButtonItem3,
            this.btnCreateAccount,
            this.barLblCurrName,
            this.btnDongHocPhi,
            this.btnSignOut,
            this.btnReportHocPhi,
            this.btnDSThiHetMon,
            this.btnDSSV,
            this.btnBangDiem,
            this.btnDHP});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barLblCurrName);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.btnSignOut);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1521, 141);
            // 
            // btnReportStudent
            // 
            this.btnReportStudent.Caption = "Sinh Viên";
            this.btnReportStudent.Id = 1;
            this.btnReportStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReportStudent.ImageOptions.Image")));
            this.btnReportStudent.LargeWidth = 100;
            this.btnReportStudent.Name = "btnReportStudent";
            this.btnReportStudent.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Caption = "Sinh Viên";
            this.btnManageStudents.DropDownEnabled = false;
            this.btnManageStudents.Id = 2;
            this.btnManageStudents.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManageStudents.ImageOptions.Image")));
            this.btnManageStudents.LargeWidth = 100;
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnManageStudents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnManageStudents_ItemClick);
            // 
            // btnClass
            // 
            this.btnClass.Caption = "Lớp";
            this.btnClass.Id = 3;
            this.btnClass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.ImageOptions.Image")));
            this.btnClass.LargeWidth = 100;
            this.btnClass.Name = "btnClass";
            this.btnClass.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClass_ItemClick);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Caption = "Môn Học";
            this.btnSubjects.Id = 4;
            this.btnSubjects.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubjects.ImageOptions.Image")));
            this.btnSubjects.LargeWidth = 100;
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSubjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubjects_ItemClick);
            // 
            // btnScores
            // 
            this.btnScores.Caption = "Điểm";
            this.btnScores.Id = 5;
            this.btnScores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnScores.ImageOptions.Image")));
            this.btnScores.LargeWidth = 100;
            this.btnScores.Name = "btnScores";
            this.btnScores.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnScores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnScores_ItemClick);
            // 
            // btnDongHP
            // 
            this.btnDongHP.Caption = "In ds đong học phí";
            this.btnDongHP.Id = 6;
            this.btnDongHP.Name = "btnDongHP";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh sách thi hết môn";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Caption = "Tạo Tài Khoản";
            this.btnCreateAccount.DropDownEnabled = false;
            this.btnCreateAccount.Id = 3;
            this.btnCreateAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.ImageOptions.Image")));
            this.btnCreateAccount.LargeWidth = 100;
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCreateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAccount_ItemClick);
            // 
            // barLblCurrName
            // 
            this.barLblCurrName.Caption = "Tên người đăng nhập";
            this.barLblCurrName.Id = 4;
            this.barLblCurrName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLblCurrName.ImageOptions.Image")));
            this.barLblCurrName.Name = "barLblCurrName";
            this.barLblCurrName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barLblCurrName.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnDongHocPhi
            // 
            this.btnDongHocPhi.Caption = "Đóng Học Phí";
            this.btnDongHocPhi.Id = 5;
            this.btnDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongHocPhi.ImageOptions.Image")));
            this.btnDongHocPhi.LargeWidth = 100;
            this.btnDongHocPhi.Name = "btnDongHocPhi";
            this.btnDongHocPhi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongHocPhi_ItemClick);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Caption = "Đăng Xuất";
            this.btnSignOut.Id = 6;
            this.btnSignOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.ImageOptions.Image")));
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSignOut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSignOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSignOut_ItemClick);
            // 
            // btnReportHocPhi
            // 
            this.btnReportHocPhi.Caption = "Phiếu Điểm";
            this.btnReportHocPhi.Id = 7;
            this.btnReportHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReportHocPhi.ImageOptions.Image")));
            this.btnReportHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReportHocPhi.ImageOptions.LargeImage")));
            this.btnReportHocPhi.Name = "btnReportHocPhi";
            this.btnReportHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportHocPhi_ItemClick);
            // 
            // btnDSThiHetMon
            // 
            this.btnDSThiHetMon.Caption = "DS Thi Hết Môn";
            this.btnDSThiHetMon.Id = 8;
            this.btnDSThiHetMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSThiHetMon.ImageOptions.Image")));
            this.btnDSThiHetMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSThiHetMon.ImageOptions.LargeImage")));
            this.btnDSThiHetMon.Name = "btnDSThiHetMon";
            this.btnDSThiHetMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSThiHetMon_ItemClick);
            // 
            // btnDSSV
            // 
            this.btnDSSV.Caption = "DS Sinh Viên";
            this.btnDSSV.Id = 9;
            this.btnDSSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSV.ImageOptions.Image")));
            this.btnDSSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSSV.ImageOptions.LargeImage")));
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSSV_ItemClick);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Caption = "Bảng Điểm";
            this.btnBangDiem.Id = 10;
            this.btnBangDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBangDiem.ImageOptions.Image")));
            this.btnBangDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBangDiem.ImageOptions.LargeImage")));
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiem_ItemClick);
            // 
            // btnDHP
            // 
            this.btnDHP.Caption = "Đóng Học Phí";
            this.btnDHP.Id = 11;
            this.btnDHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDHP.ImageOptions.Image")));
            this.btnDHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDHP.ImageOptions.LargeImage")));
            this.btnDHP.Name = "btnDHP";
            this.btnDHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDHP_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup9,
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnManageStudents);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClass);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSubjects);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnScores);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnDongHocPhi);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnCreateAccount);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnReportHocPhi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDSThiHetMon);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDSSV);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnBangDiem);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDHP);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // xtraHome
            // 
            this.xtraHome.MdiParent = this;
            // 
            // notifySuccess
            // 
            this.notifySuccess.BalloonTipText = "QLDSV";
            this.notifySuccess.BalloonTipTitle = "Đã đăng xuất";
            this.notifySuccess.Icon = ((System.Drawing.Icon)(resources.GetObject("notifySuccess.Icon")));
            this.notifySuccess.Text = "Đã đăng xuất";
            this.notifySuccess.Visible = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 691);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnReportStudent;
        private DevExpress.XtraBars.BarButtonItem btnManageStudents;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraHome;

        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSubjects;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnScores;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDongHP;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;

        private DevExpress.XtraBars.BarButtonItem btnCreateAccount;
        private DevExpress.XtraBars.BarStaticItem barLblCurrName;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnDongHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnSignOut;
        private System.Windows.Forms.NotifyIcon notifySuccess;
        private DevExpress.XtraBars.BarButtonItem btnReportHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDSThiHetMon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnDSSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnBangDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnDHP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}