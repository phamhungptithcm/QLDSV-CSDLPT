using System;
using QLDSV.ptit.qldsv.management.home;

namespace QLDSV.ptit.qldsv.management.report
{
    partial class FromInDSSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTENLOP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHOCKI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dS_QLDSV = new QLDSV.DS_QLDSV();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTENLOP
            // 
            this.cmbTENLOP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTENLOP.FormattingEnabled = true;
            this.cmbTENLOP.Location = new System.Drawing.Point(425, 194);
            this.cmbTENLOP.Name = "cmbTENLOP";
            this.cmbTENLOP.Size = new System.Drawing.Size(598, 26);
            this.cmbTENLOP.TabIndex = 0;
            this.cmbTENLOP.SelectedIndexChanged += new System.EventHandler(this.cmbTENLOP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Lớp :";
            // 
            // cmbNIENKHOA
            // 
            this.cmbNIENKHOA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNIENKHOA.FormattingEnabled = true;
            this.cmbNIENKHOA.Location = new System.Drawing.Point(425, 313);
            this.cmbNIENKHOA.Name = "cmbNIENKHOA";
            this.cmbNIENKHOA.Size = new System.Drawing.Size(351, 26);
            this.cmbNIENKHOA.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nien Khóa :";
            // 
            // cmbHOCKI
            // 
            this.cmbHOCKI.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHOCKI.FormattingEnabled = true;
            this.cmbHOCKI.Location = new System.Drawing.Point(425, 440);
            this.cmbHOCKI.Name = "cmbHOCKI";
            this.cmbHOCKI.Size = new System.Drawing.Size(242, 26);
            this.cmbHOCKI.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học Kỳ :";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(507, 552);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(364, 96);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dS_QLDSV
            // 
            this.dS_QLDSV.DataSetName = "DS_QLDSV";
            this.dS_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 813);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHOCKI);
            this.Controls.Add(this.cmbNIENKHOA);
            this.Controls.Add(this.cmbTENLOP);
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.Load += new System.EventHandler(this.FormInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLDSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTENLOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNIENKHOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHOCKI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private DS_QLDSV dS_QLDSV;

        public Home MdiParent { get; internal set; }
    }
}