namespace QLDSV.ptit.qldsv.management.school_fee
{
    partial class SchoolFee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolFee));
            this.grbStudentConditionSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.sp_GetValueDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetValueDiemTableAdapter = new QLDSV.DS_QLDSVTableAdapters.sp_GetValueDiemTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.sp_GetHocPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetHocPhiTableAdapter = new QLDSV.DS_QLDSVTableAdapters.sp_GetHocPhiTableAdapter();
            this.grbStudentInfor = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTitleGender = new System.Windows.Forms.Label();
            this.lblDayOfBirth = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTitleDayOfBirth = new System.Windows.Forms.Label();
            this.lblTitleClass = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblTitleFullname = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDongHocPhi = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.grbStudentConditionSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetValueDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetHocPhiBindingSource)).BeginInit();
            this.grbStudentInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDongHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudentConditionSearch
            // 
            this.grbStudentConditionSearch.Controls.Add(this.btnSearch);
            this.grbStudentConditionSearch.Controls.Add(this.lblMaSV);
            this.grbStudentConditionSearch.Controls.Add(this.txtMaSV);
            this.grbStudentConditionSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbStudentConditionSearch.Location = new System.Drawing.Point(0, 58);
            this.grbStudentConditionSearch.Name = "grbStudentConditionSearch";
            this.grbStudentConditionSearch.Size = new System.Drawing.Size(1930, 100);
            this.grbStudentConditionSearch.TabIndex = 0;
            this.grbStudentConditionSearch.TabStop = false;
            this.grbStudentConditionSearch.Text = "Tìm Sinh Viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(460, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(12, 39);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(66, 13);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(110, 36);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(300, 21);
            this.txtMaSV.TabIndex = 1;
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetValueDiemBindingSource
            // 
            this.sp_GetValueDiemBindingSource.DataMember = "sp_GetValueDiem";
            this.sp_GetValueDiemBindingSource.DataSource = this.dS_QLDSV;
            // 
            // sp_GetValueDiemTableAdapter
            // 
            this.sp_GetValueDiemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_GetHocPhiBindingSource
            // 
            this.sp_GetHocPhiBindingSource.DataMember = "sp_GetHocPhi";
            this.sp_GetHocPhiBindingSource.DataSource = this.dS_QLDSV;
            // 
            // sp_GetHocPhiTableAdapter
            // 
            this.sp_GetHocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // grbStudentInfor
            // 
            this.grbStudentInfor.Controls.Add(this.lblGender);
            this.grbStudentInfor.Controls.Add(this.lblTitleGender);
            this.grbStudentInfor.Controls.Add(this.lblDayOfBirth);
            this.grbStudentInfor.Controls.Add(this.lblClass);
            this.grbStudentInfor.Controls.Add(this.lblTitleDayOfBirth);
            this.grbStudentInfor.Controls.Add(this.lblTitleClass);
            this.grbStudentInfor.Controls.Add(this.lblFullname);
            this.grbStudentInfor.Controls.Add(this.lblTitleFullname);
            this.grbStudentInfor.Controls.Add(this.lblTitle);
            this.grbStudentInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbStudentInfor.Location = new System.Drawing.Point(0, 158);
            this.grbStudentInfor.Name = "grbStudentInfor";
            this.grbStudentInfor.Size = new System.Drawing.Size(1930, 141);
            this.grbStudentInfor.TabIndex = 3;
            this.grbStudentInfor.TabStop = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(1453, 71);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "gioitinh";
            // 
            // lblTitleGender
            // 
            this.lblTitleGender.AutoSize = true;
            this.lblTitleGender.Location = new System.Drawing.Point(1350, 71);
            this.lblTitleGender.Name = "lblTitleGender";
            this.lblTitleGender.Size = new System.Drawing.Size(49, 13);
            this.lblTitleGender.TabIndex = 7;
            this.lblTitleGender.Text = "Giới tính:";
            // 
            // lblDayOfBirth
            // 
            this.lblDayOfBirth.AutoSize = true;
            this.lblDayOfBirth.Location = new System.Drawing.Point(1080, 71);
            this.lblDayOfBirth.Name = "lblDayOfBirth";
            this.lblDayOfBirth.Size = new System.Drawing.Size(50, 13);
            this.lblDayOfBirth.TabIndex = 6;
            this.lblDayOfBirth.Text = "ngaysinh";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(754, 71);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(30, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "class";
            // 
            // lblTitleDayOfBirth
            // 
            this.lblTitleDayOfBirth.AutoSize = true;
            this.lblTitleDayOfBirth.Location = new System.Drawing.Point(976, 71);
            this.lblTitleDayOfBirth.Name = "lblTitleDayOfBirth";
            this.lblTitleDayOfBirth.Size = new System.Drawing.Size(58, 13);
            this.lblTitleDayOfBirth.TabIndex = 4;
            this.lblTitleDayOfBirth.Text = "Ngày sinh:";
            // 
            // lblTitleClass
            // 
            this.lblTitleClass.AutoSize = true;
            this.lblTitleClass.Location = new System.Drawing.Point(682, 71);
            this.lblTitleClass.Name = "lblTitleClass";
            this.lblTitleClass.Size = new System.Drawing.Size(31, 13);
            this.lblTitleClass.TabIndex = 3;
            this.lblTitleClass.Text = "Lớp: ";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(445, 71);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(33, 13);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "name";
            // 
            // lblTitleFullname
            // 
            this.lblTitleFullname.AutoSize = true;
            this.lblTitleFullname.Location = new System.Drawing.Point(371, 71);
            this.lblTitleFullname.Name = "lblTitleFullname";
            this.lblTitleFullname.Size = new System.Drawing.Size(46, 13);
            this.lblTitleFullname.TabIndex = 1;
            this.lblTitleFullname.Text = "Họ tên: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(896, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin đóng học phí sinh viên";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.grdDongHocPhi;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // grdDongHocPhi
            // 
            this.grdDongHocPhi.DataSource = this.sp_GetHocPhiBindingSource;
            this.grdDongHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdDongHocPhi.Location = new System.Drawing.Point(0, 299);
            this.grdDongHocPhi.MainView = this.gridView1;
            this.grdDongHocPhi.Name = "grdDongHocPhi";
            this.grdDongHocPhi.Size = new System.Drawing.Size(1930, 220);
            this.grdDongHocPhi.TabIndex = 3;
            this.grdDongHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnUpdate,
            this.btnCancel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1930, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1045);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1930, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 987);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1930, 58);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 987);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Cập Nhật";
            this.btnUpdate.Id = 0;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy";
            this.btnCancel.Id = 1;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // SchoolFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 1068);
            this.Controls.Add(this.grdDongHocPhi);
            this.Controls.Add(this.grbStudentInfor);
            this.Controls.Add(this.grbStudentConditionSearch);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SchoolFee";
            this.Text = "SchoolFee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SchoolFee_Load);
            this.grbStudentConditionSearch.ResumeLayout(false);
            this.grbStudentConditionSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetValueDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetHocPhiBindingSource)).EndInit();
            this.grbStudentInfor.ResumeLayout(false);
            this.grbStudentInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDongHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentConditionSearch;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnSearch;
        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.BindingSource sp_GetValueDiemBindingSource;
        private DS_QLDSVTableAdapters.sp_GetValueDiemTableAdapter sp_GetValueDiemTableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_GetHocPhiBindingSource;
        private DS_QLDSVTableAdapters.sp_GetHocPhiTableAdapter sp_GetHocPhiTableAdapter;
        private System.Windows.Forms.GroupBox grbStudentInfor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraGrid.GridControl grdDongHocPhi;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTitleGender;
        private System.Windows.Forms.Label lblDayOfBirth;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTitleDayOfBirth;
        private System.Windows.Forms.Label lblTitleClass;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblTitleFullname;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}