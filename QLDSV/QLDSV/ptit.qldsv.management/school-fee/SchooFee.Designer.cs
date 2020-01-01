namespace QLDSV.ptit.qldsv.management.school_fee
{
    partial class SchooFee
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label sOTIENDADONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchooFee));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grbSearchStudent = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblMaSVInfo = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTitleClass = new System.Windows.Forms.Label();
            this.lblTitleMaSV = new System.Windows.Forms.Label();
            this.lblTitleGender = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHITableAdapter = new QLDSV.DS_QLDSVTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV.DS_QLDSVTableAdapters.TableAdapterManager();
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbUpdateSchooFee = new System.Windows.Forms.GroupBox();
            this.grbNienKhoa = new System.Windows.Forms.GroupBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSoTienDaDong = new DevExpress.XtraEditors.SpinEdit();
            this.txtHocPhi = new DevExpress.XtraEditors.SpinEdit();
            this.txtHocKi = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            sOTIENDADONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.grbSearchStudent.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grbUpdateSchooFee.SuspendLayout();
            this.grbNienKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(533, 136);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(55, 13);
            nIENKHOALabel.TabIndex = 0;
            nIENKHOALabel.Text = "Niên Khóa";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(1050, 136);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(40, 13);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "Học Kỳ";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(533, 225);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(42, 13);
            hOCPHILabel.TabIndex = 6;
            hOCPHILabel.Text = "Học Phí";
            // 
            // sOTIENDADONGLabel
            // 
            sOTIENDADONGLabel.AutoSize = true;
            sOTIENDADONGLabel.Location = new System.Drawing.Point(1050, 221);
            sOTIENDADONGLabel.Name = "sOTIENDADONGLabel";
            sOTIENDADONGLabel.Size = new System.Drawing.Size(82, 13);
            sOTIENDADONGLabel.TabIndex = 8;
            sOTIENDADONGLabel.Text = "Số tiền đã đóng";
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
            this.btnAddNew,
            this.btnUpdate,
            this.btnSave,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Caption = "Thêm";
            this.btnAddNew.Id = 0;
            this.btnAddNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ImageOptions.Image")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 3;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
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
            // grbSearchStudent
            // 
            this.grbSearchStudent.Controls.Add(this.btnSearch);
            this.grbSearchStudent.Controls.Add(this.txtKeyword);
            this.grbSearchStudent.Controls.Add(this.lblMaSV);
            this.grbSearchStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearchStudent.Location = new System.Drawing.Point(0, 58);
            this.grbSearchStudent.Name = "grbSearchStudent";
            this.grbSearchStudent.Size = new System.Drawing.Size(1930, 91);
            this.grbSearchStudent.TabIndex = 4;
            this.grbSearchStudent.TabStop = false;
            this.grbSearchStudent.Text = "Tìm kiếm sinh viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(453, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(115, 39);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(300, 21);
            this.txtKeyword.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(24, 42);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(66, 13);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.lblTitleName);
            this.grbStudentInfo.Controls.Add(this.lblFullname);
            this.grbStudentInfo.Controls.Add(this.lblMaSVInfo);
            this.grbStudentInfo.Controls.Add(this.lblClass);
            this.grbStudentInfo.Controls.Add(this.lblTitleClass);
            this.grbStudentInfo.Controls.Add(this.lblTitleMaSV);
            this.grbStudentInfo.Controls.Add(this.lblTitleGender);
            this.grbStudentInfo.Controls.Add(this.lblGender);
            this.grbStudentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbStudentInfo.Location = new System.Drawing.Point(0, 149);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(1930, 100);
            this.grbStudentInfo.TabIndex = 5;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Thông tin đóng học phí của sinh viên";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(720, 52);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(43, 13);
            this.lblTitleName.TabIndex = 3;
            this.lblTitleName.Text = "Họ tên:";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(797, 52);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(47, 13);
            this.lblFullname.TabIndex = 4;
            this.lblFullname.Text = "fullname";
            // 
            // lblMaSVInfo
            // 
            this.lblMaSVInfo.AutoSize = true;
            this.lblMaSVInfo.Location = new System.Drawing.Point(550, 52);
            this.lblMaSVInfo.Name = "lblMaSVInfo";
            this.lblMaSVInfo.Size = new System.Drawing.Size(32, 13);
            this.lblMaSVInfo.TabIndex = 5;
            this.lblMaSVInfo.Text = "masv";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(1095, 52);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(30, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "class";
            // 
            // lblTitleClass
            // 
            this.lblTitleClass.AutoSize = true;
            this.lblTitleClass.Location = new System.Drawing.Point(1035, 52);
            this.lblTitleClass.Name = "lblTitleClass";
            this.lblTitleClass.Size = new System.Drawing.Size(28, 13);
            this.lblTitleClass.TabIndex = 7;
            this.lblTitleClass.Text = "Lớp:";
            // 
            // lblTitleMaSV
            // 
            this.lblTitleMaSV.AutoSize = true;
            this.lblTitleMaSV.Location = new System.Drawing.Point(450, 52);
            this.lblTitleMaSV.Name = "lblTitleMaSV";
            this.lblTitleMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblTitleMaSV.TabIndex = 8;
            this.lblTitleMaSV.Text = "Mã sinh viên:";
            // 
            // lblTitleGender
            // 
            this.lblTitleGender.AutoSize = true;
            this.lblTitleGender.Location = new System.Drawing.Point(1309, 52);
            this.lblTitleGender.Name = "lblTitleGender";
            this.lblTitleGender.Size = new System.Drawing.Size(49, 13);
            this.lblTitleGender.TabIndex = 9;
            this.lblTitleGender.Text = "Giới tính:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(1391, 52);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "gender";
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.dS_QLDSV;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.DataSource = this.hOCPHIBindingSource;
            this.hOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hOCPHIGridControl.Location = new System.Drawing.Point(0, 249);
            this.hOCPHIGridControl.MainView = this.gridView1;
            this.hOCPHIGridControl.MenuManager = this.barManager1;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(1930, 220);
            this.hOCPHIGridControl.TabIndex = 8;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.hOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.AllowEdit = false;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.AllowEdit = false;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.AllowEdit = false;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.AllowEdit = false;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // grbUpdateSchooFee
            // 
            this.grbUpdateSchooFee.Controls.Add(this.grbNienKhoa);
            this.grbUpdateSchooFee.Controls.Add(this.pictureBox1);
            this.grbUpdateSchooFee.Controls.Add(sOTIENDADONGLabel);
            this.grbUpdateSchooFee.Controls.Add(this.txtSoTienDaDong);
            this.grbUpdateSchooFee.Controls.Add(hOCPHILabel);
            this.grbUpdateSchooFee.Controls.Add(this.txtHocPhi);
            this.grbUpdateSchooFee.Controls.Add(hOCKYLabel);
            this.grbUpdateSchooFee.Controls.Add(this.txtHocKi);
            this.grbUpdateSchooFee.Controls.Add(nIENKHOALabel);
            this.grbUpdateSchooFee.Controls.Add(this.txtNienKhoa);
            this.grbUpdateSchooFee.Controls.Add(this.txtMaSV);
            this.grbUpdateSchooFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbUpdateSchooFee.Location = new System.Drawing.Point(0, 469);
            this.grbUpdateSchooFee.Name = "grbUpdateSchooFee";
            this.grbUpdateSchooFee.Size = new System.Drawing.Size(1930, 329);
            this.grbUpdateSchooFee.TabIndex = 9;
            this.grbUpdateSchooFee.TabStop = false;
            this.grbUpdateSchooFee.Text = "Cập nhật đóng học phí";
            // 
            // grbNienKhoa
            // 
            this.grbNienKhoa.Controls.Add(this.dateFrom);
            this.grbNienKhoa.Controls.Add(this.dateTo);
            this.grbNienKhoa.Location = new System.Drawing.Point(602, 124);
            this.grbNienKhoa.Name = "grbNienKhoa";
            this.grbNienKhoa.Size = new System.Drawing.Size(300, 38);
            this.grbNienKhoa.TabIndex = 13;
            this.grbNienKhoa.TabStop = false;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(6, 11);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(120, 21);
            this.dateFrom.TabIndex = 11;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTo.Location = new System.Drawing.Point(180, 11);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(120, 21);
            this.dateTo.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtSoTienDaDong
            // 
            this.txtSoTienDaDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOCPHIBindingSource, "SOTIENDADONG", true));
            this.txtSoTienDaDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTienDaDong.Location = new System.Drawing.Point(1147, 218);
            this.txtSoTienDaDong.MenuManager = this.barManager1;
            this.txtSoTienDaDong.Name = "txtSoTienDaDong";
            this.txtSoTienDaDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienDaDong.Size = new System.Drawing.Size(300, 20);
            this.txtSoTienDaDong.TabIndex = 9;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOCPHIBindingSource, "HOCPHI", true));
            this.txtHocPhi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHocPhi.Location = new System.Drawing.Point(602, 222);
            this.txtHocPhi.MenuManager = this.barManager1;
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocPhi.Size = new System.Drawing.Size(300, 20);
            this.txtHocPhi.TabIndex = 7;
            // 
            // txtHocKi
            // 
            this.txtHocKi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOCPHIBindingSource, "HOCKY", true));
            this.txtHocKi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHocKi.Location = new System.Drawing.Point(1147, 133);
            this.txtHocKi.MenuManager = this.barManager1;
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKi.Size = new System.Drawing.Size(300, 20);
            this.txtHocKi.TabIndex = 5;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOCPHIBindingSource, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(602, 133);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(300, 20);
            this.txtNienKhoa.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOCPHIBindingSource, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(602, 133);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(300, 20);
            this.txtMaSV.TabIndex = 3;
            // 
            // SchooFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 1068);
            this.Controls.Add(this.grbUpdateSchooFee);
            this.Controls.Add(this.hOCPHIGridControl);
            this.Controls.Add(this.grbStudentInfo);
            this.Controls.Add(this.grbSearchStudent);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SchooFee";
            this.Text = "SchooFee";
            this.Load += new System.EventHandler(this.SchooFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.grbSearchStudent.ResumeLayout(false);
            this.grbSearchStudent.PerformLayout();
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grbUpdateSchooFee.ResumeLayout(false);
            this.grbUpdateSchooFee.PerformLayout();
            this.grbNienKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private DS_QLDSV dS_QLDSV;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblMaSVInfo;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTitleClass;
        private System.Windows.Forms.Label lblTitleMaSV;
        private System.Windows.Forms.Label lblTitleGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox grbSearchStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblMaSV;
        private DS_QLDSVTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private DS_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox grbUpdateSchooFee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SpinEdit txtSoTienDaDong;
        private DevExpress.XtraEditors.SpinEdit txtHocPhi;
        private DevExpress.XtraEditors.SpinEdit txtHocKi;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.GroupBox grbNienKhoa;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
    }
}