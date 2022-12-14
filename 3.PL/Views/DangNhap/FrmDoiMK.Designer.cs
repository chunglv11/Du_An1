namespace _3.PL.Views.DangNhap
{
    partial class FrmDoiMK
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nlmk = new System.Windows.Forms.TextBox();
            this.tb_mkm = new System.Windows.Forms.TextBox();
            this.tb_mkc = new System.Windows.Forms.TextBox();
            this.btn_DoiMK_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // tb_nlmk
            // 
            this.tb_nlmk.Location = new System.Drawing.Point(232, 169);
            this.tb_nlmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nlmk.Name = "tb_nlmk";
            this.tb_nlmk.Size = new System.Drawing.Size(274, 27);
            this.tb_nlmk.TabIndex = 17;
            // 
            // tb_mkm
            // 
            this.tb_mkm.Location = new System.Drawing.Point(232, 92);
            this.tb_mkm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mkm.Name = "tb_mkm";
            this.tb_mkm.Size = new System.Drawing.Size(274, 27);
            this.tb_mkm.TabIndex = 16;
            // 
            // tb_mkc
            // 
            this.tb_mkc.Location = new System.Drawing.Point(232, 20);
            this.tb_mkc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mkc.Name = "tb_mkc";
            this.tb_mkc.Size = new System.Drawing.Size(274, 27);
            this.tb_mkc.TabIndex = 15;
            // 
            // btn_DoiMK_XacNhan
            // 
            this.btn_DoiMK_XacNhan.Location = new System.Drawing.Point(355, 238);
            this.btn_DoiMK_XacNhan.Name = "btn_DoiMK_XacNhan";
            this.btn_DoiMK_XacNhan.Size = new System.Drawing.Size(151, 38);
            this.btn_DoiMK_XacNhan.TabIndex = 21;
            this.btn_DoiMK_XacNhan.Text = "Xác nhận";
            this.btn_DoiMK_XacNhan.UseVisualStyleBackColor = true;
            this.btn_DoiMK_XacNhan.Click += new System.EventHandler(this.btn_DoiMK_XacNhan_Click);
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 301);
            this.Controls.Add(this.btn_DoiMK_XacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nlmk);
            this.Controls.Add(this.tb_mkm);
            this.Controls.Add(this.tb_mkc);
            this.Name = "FrmDoiMK";
            this.Text = "FrmDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_nlmk;
        private TextBox tb_mkm;
        private TextBox tb_mkc;
        private Button btn_DoiMK_XacNhan;
    }
}