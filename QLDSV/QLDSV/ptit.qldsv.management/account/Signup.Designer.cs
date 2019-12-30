namespace QLDSV.ptit.qldsv.management.account
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.notifySuccess = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyFail = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(240, 335);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(367, 21);
            this.cmbRole.TabIndex = 0;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(240, 228);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(367, 20);
            this.txtConfPass.TabIndex = 1;
            this.txtConfPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(240, 117);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(367, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(240, 277);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(367, 21);
            this.cmbTeacher.TabIndex = 3;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(240, 174);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(367, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(513, 412);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo Tài Khoản";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(128, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(128, 177);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Mật Khẩu";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(128, 231);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(104, 13);
            this.lblConfirmPass.TabIndex = 8;
            this.lblConfirmPass.Text = "Xác Nhận Mật Khẩu";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(130, 338);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(47, 13);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Chức vụ";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(130, 280);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(59, 13);
            this.lblTeacher.TabIndex = 10;
            this.lblTeacher.Text = "Giảng Viên";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tạo tài khoản";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.cmbRole);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.NotifyIcon notifySuccess;
        private System.Windows.Forms.NotifyIcon notifyFail;
        private System.Windows.Forms.Label label1;
    }
}