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
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.grbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.btnSearch);
            this.grbStudentInfo.Controls.Add(this.lblMaSV);
            this.grbStudentInfo.Controls.Add(this.txtMaSV);
            this.grbStudentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbStudentInfo.Location = new System.Drawing.Point(0, 0);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(1930, 100);
            this.grbStudentInfo.TabIndex = 0;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Tìm Sinh Viên";
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
            // SchoolFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 1068);
            this.Controls.Add(this.grbStudentInfo);
            this.Name = "SchoolFee";
            this.Text = "SchoolFee";
            this.Load += new System.EventHandler(this.SchoolFee_Load);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnSearch;
    }
}