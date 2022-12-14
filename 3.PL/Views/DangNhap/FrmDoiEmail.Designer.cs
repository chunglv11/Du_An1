namespace _3.PL.Views.DangNhap
{
    partial class FrmDoiEmail
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
            this.tb_EmailMoi = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DoiEmail_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_EmailMoi
            // 
            this.tb_EmailMoi.Location = new System.Drawing.Point(173, 115);
            this.tb_EmailMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmailMoi.Name = "tb_EmailMoi";
            this.tb_EmailMoi.Size = new System.Drawing.Size(386, 27);
            this.tb_EmailMoi.TabIndex = 13;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(173, 34);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(386, 27);
            this.tb_Email.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // btn_DoiEmail_XacNhan
            // 
            this.btn_DoiEmail_XacNhan.Location = new System.Drawing.Point(427, 184);
            this.btn_DoiEmail_XacNhan.Name = "btn_DoiEmail_XacNhan";
            this.btn_DoiEmail_XacNhan.Size = new System.Drawing.Size(132, 35);
            this.btn_DoiEmail_XacNhan.TabIndex = 14;
            this.btn_DoiEmail_XacNhan.Text = "Xác nhận";
            this.btn_DoiEmail_XacNhan.UseVisualStyleBackColor = true;
            this.btn_DoiEmail_XacNhan.Click += new System.EventHandler(this.btn_DoiEmail_XacNhan_Click);
            // 
            // FrmDoiEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 241);
            this.Controls.Add(this.btn_DoiEmail_XacNhan);
            this.Controls.Add(this.tb_EmailMoi);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiEmail";
            this.Text = "FrmDoiEmail";
            this.Load += new System.EventHandler(this.FrmDoiEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_EmailMoi;
        private TextBox tb_Email;
        private Label label2;
        private Label label1;
        private Button btn_DoiEmail_XacNhan;
    }
}