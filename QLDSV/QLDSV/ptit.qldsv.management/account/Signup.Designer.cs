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
            this.grbSignup = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.grbSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSignup
            // 
            this.grbSignup.Controls.Add(this.cmbGroup);
            this.grbSignup.Controls.Add(this.cmb);
            this.grbSignup.Controls.Add(this.txtUsername);
            this.grbSignup.Controls.Add(this.txtPassword);
            this.grbSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSignup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSignup.Location = new System.Drawing.Point(0, 0);
            this.grbSignup.Name = "grbSignup";
            this.grbSignup.Size = new System.Drawing.Size(1930, 683);
            this.grbSignup.TabIndex = 0;
            this.grbSignup.TabStop = false;
            this.grbSignup.Text = "Tạo một tài khoản mới";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(641, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 21);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(344, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 21);
            this.txtUsername.TabIndex = 1;
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(641, 160);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(265, 21);
            this.cmb.TabIndex = 2;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(344, 160);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(243, 21);
            this.cmbGroup.TabIndex = 3;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 683);
            this.Controls.Add(this.grbSignup);
            this.Name = "Signup";
            this.Text = "Signup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Signup_Load);
            this.grbSignup.ResumeLayout(false);
            this.grbSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSignup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}