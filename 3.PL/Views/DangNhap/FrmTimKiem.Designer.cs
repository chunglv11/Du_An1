namespace _3.PL.Views.DangNhap
{
    partial class FrmTimKiem
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
            this.tb_otp = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.anButtons1 = new System.Windows.Forms.Button();
            this.anButtons2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_otp
            // 
            this.tb_otp.Location = new System.Drawing.Point(385, 115);
            this.tb_otp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_otp.Name = "tb_otp";
            this.tb_otp.PlaceholderText = "Nhập Mã OTP ";
            this.tb_otp.Size = new System.Drawing.Size(248, 27);
            this.tb_otp.TabIndex = 13;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(51, 62);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_email.Name = "tb_email";
            this.tb_email.PlaceholderText = "Nhập gmail đăng kí tài khoản...";
            this.tb_email.Size = new System.Drawing.Size(582, 27);
            this.tb_email.TabIndex = 12;
            // 
            // anButtons1
            // 
            this.anButtons1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anButtons1.Location = new System.Drawing.Point(51, 113);
            this.anButtons1.Name = "anButtons1";
            this.anButtons1.Size = new System.Drawing.Size(142, 29);
            this.anButtons1.TabIndex = 14;
            this.anButtons1.Text = "Lấy Mã OTP";
            this.anButtons1.UseVisualStyleBackColor = true;
            this.anButtons1.Click += new System.EventHandler(this.anButtons1_Click);
            // 
            // anButtons2
            // 
            this.anButtons2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anButtons2.Location = new System.Drawing.Point(51, 167);
            this.anButtons2.Name = "anButtons2";
            this.anButtons2.Size = new System.Drawing.Size(142, 29);
            this.anButtons2.TabIndex = 15;
            this.anButtons2.Text = "Xác Nhận Mã OTP";
            this.anButtons2.UseVisualStyleBackColor = true;
            this.anButtons2.Click += new System.EventHandler(this.anButtons2_Click);
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 219);
            this.Controls.Add(this.anButtons2);
            this.Controls.Add(this.anButtons1);
            this.Controls.Add(this.tb_otp);
            this.Controls.Add(this.tb_email);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "FrmTimKiem";
            this.Text = "FrmTimKiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_otp;
        private TextBox tb_email;
        private Button anButtons1;
        private Button anButtons2;
    }
}