namespace QLDSV.ptit.qldsv.management.student
{
    partial class TransferClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferClass));
            this.cmbKhoaFormChuyenLop = new System.Windows.Forms.ComboBox();
            this.formTransferClass = new System.Windows.Forms.GroupBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblTitleBirth = new System.Windows.Forms.Label();
            this.lblTitleStudentId = new System.Windows.Forms.Label();
            this.lblTitleClassId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblDayOfBirth = new System.Windows.Forms.Label();
            this.lblClassId = new System.Windows.Forms.Label();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifySuccess = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyFail = new System.Windows.Forms.NotifyIcon(this.components);
            this.formTransferClass.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKhoaFormChuyenLop
            // 
            this.cmbKhoaFormChuyenLop.FormattingEnabled = true;
            this.cmbKhoaFormChuyenLop.Location = new System.Drawing.Point(161, 68);
            this.cmbKhoaFormChuyenLop.Name = "cmbKhoaFormChuyenLop";
            this.cmbKhoaFormChuyenLop.Size = new System.Drawing.Size(492, 21);
            this.cmbKhoaFormChuyenLop.TabIndex = 0;
            this.cmbKhoaFormChuyenLop.SelectedIndexChanged += new System.EventHandler(this.cmbKhoaFormChuyenLop_SelectedIndexChanged);
            // 
            // formTransferClass
            // 
            this.formTransferClass.Controls.Add(this.cmbClass);
            this.formTransferClass.Controls.Add(this.btnSave);
            this.formTransferClass.Controls.Add(this.lblClass);
            this.formTransferClass.Controls.Add(this.lblKhoa);
            this.formTransferClass.Controls.Add(this.cmbKhoaFormChuyenLop);
            this.formTransferClass.Location = new System.Drawing.Point(0, 163);
            this.formTransferClass.Name = "formTransferClass";
            this.formTransferClass.Size = new System.Drawing.Size(786, 397);
            this.formTransferClass.TabIndex = 4;
            this.formTransferClass.TabStop = false;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(161, 145);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(492, 21);
            this.cmbClass.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(578, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Thực hiện";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(107, 148);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(25, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Lớp";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(107, 71);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(72, 85);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(45, 13);
            this.lblTitleName.TabIndex = 5;
            this.lblTitleName.Text = "Họ tên: ";
            // 
            // lblTitleBirth
            // 
            this.lblTitleBirth.AutoSize = true;
            this.lblTitleBirth.Location = new System.Drawing.Point(72, 116);
            this.lblTitleBirth.Name = "lblTitleBirth";
            this.lblTitleBirth.Size = new System.Drawing.Size(57, 13);
            this.lblTitleBirth.TabIndex = 6;
            this.lblTitleBirth.Text = "Ngày sinh:";
            // 
            // lblTitleStudentId
            // 
            this.lblTitleStudentId.AutoSize = true;
            this.lblTitleStudentId.Location = new System.Drawing.Point(420, 85);
            this.lblTitleStudentId.Name = "lblTitleStudentId";
            this.lblTitleStudentId.Size = new System.Drawing.Size(70, 13);
            this.lblTitleStudentId.TabIndex = 7;
            this.lblTitleStudentId.Text = "Mã sinh viên:";
            // 
            // lblTitleClassId
            // 
            this.lblTitleClassId.AutoSize = true;
            this.lblTitleClassId.Location = new System.Drawing.Point(420, 116);
            this.lblTitleClassId.Name = "lblTitleClassId";
            this.lblTitleClassId.Size = new System.Drawing.Size(42, 13);
            this.lblTitleClassId.TabIndex = 8;
            this.lblTitleClassId.Text = "Mã lớp:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(148, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "name";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(507, 85);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(60, 13);
            this.lblStudentId.TabIndex = 10;
            this.lblStudentId.Text = "masinhvien";
            // 
            // lblDayOfBirth
            // 
            this.lblDayOfBirth.AutoSize = true;
            this.lblDayOfBirth.Location = new System.Drawing.Point(148, 116);
            this.lblDayOfBirth.Name = "lblDayOfBirth";
            this.lblDayOfBirth.Size = new System.Drawing.Size(53, 13);
            this.lblDayOfBirth.TabIndex = 11;
            this.lblDayOfBirth.Text = "dayofbirth";
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Location = new System.Drawing.Point(507, 116);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(35, 13);
            this.lblClassId.TabIndex = 12;
            this.lblClassId.Text = "malop";
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.label1);
            this.grbStudentInfo.Location = new System.Drawing.Point(0, 2);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(786, 168);
            this.grbStudentInfo.TabIndex = 13;
            this.grbStudentInfo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên đang được thực hiện chuyển lớp";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifySuccess
            // 
            this.notifySuccess.BalloonTipText = "QLDSV";
            this.notifySuccess.BalloonTipTitle = "Thành Công";
            this.notifySuccess.Icon = ((System.Drawing.Icon)(resources.GetObject("notifySuccess.Icon")));
            this.notifySuccess.Text = "Thành Công";
            this.notifySuccess.Visible = true;
            // 
            // notifyFail
            // 
            this.notifyFail.BalloonTipText = "QLDSV";
            this.notifyFail.BalloonTipTitle = "Thất Bại";
            this.notifyFail.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyFail.Icon")));
            this.notifyFail.Text = "Thất Bại";
            this.notifyFail.Visible = true;
            // 
            // TransferClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.lblDayOfBirth);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitleClassId);
            this.Controls.Add(this.lblTitleStudentId);
            this.Controls.Add(this.lblTitleBirth);
            this.Controls.Add(this.lblTitleName);
            this.Controls.Add(this.formTransferClass);
            this.Controls.Add(this.grbStudentInfo);
            this.Name = "TransferClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Lớp";
            this.Load += new System.EventHandler(this.TransferClass_Load);
            this.formTransferClass.ResumeLayout(false);
            this.formTransferClass.PerformLayout();
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoaFormChuyenLop;
        private System.Windows.Forms.GroupBox formTransferClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblTitleBirth;
        private System.Windows.Forms.Label lblTitleStudentId;
        private System.Windows.Forms.Label lblTitleClassId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblDayOfBirth;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifySuccess;
        private System.Windows.Forms.NotifyIcon notifyFail;
    }
}