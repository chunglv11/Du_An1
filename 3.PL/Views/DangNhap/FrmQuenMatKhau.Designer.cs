namespace _3.PL.Views.DangNhap
{
    partial class FrmQuenMatKhau
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nhaplai = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.lb_loichao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Gmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã";
            // 
            // tb_nhaplai
            // 
            this.tb_nhaplai.Location = new System.Drawing.Point(208, 325);
            this.tb_nhaplai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nhaplai.Name = "tb_nhaplai";
            this.tb_nhaplai.Size = new System.Drawing.Size(469, 27);
            this.tb_nhaplai.TabIndex = 25;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(208, 263);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(469, 27);
            this.tb_pass.TabIndex = 24;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(208, 201);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(469, 27);
            this.tb_email.TabIndex = 23;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(208, 138);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(469, 27);
            this.tb_ma.TabIndex = 22;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(528, 411);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(149, 40);
            this.btn_xacnhan.TabIndex = 30;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // lb_loichao
            // 
            this.lb_loichao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_loichao.Location = new System.Drawing.Point(68, 20);
            this.lb_loichao.Name = "lb_loichao";
            this.lb_loichao.Size = new System.Drawing.Size(556, 56);
            this.lb_loichao.TabIndex = 31;
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 485);
            this.Controls.Add(this.lb_loichao);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nhaplai);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_ma);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.Load += new System.EventHandler(this.FrmQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_nhaplai;
        private TextBox tb_pass;
        private TextBox tb_email;
        private TextBox tb_ma;
        private Button btn_xacnhan;
        private Label lb_loichao;
    }
}