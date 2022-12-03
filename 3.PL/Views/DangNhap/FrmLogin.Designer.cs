namespace _3.PL.Views.DangNhap
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.cb_GhiNho = new System.Windows.Forms.CheckBox();
            this.lb_QuenMk = new System.Windows.Forms.Label();
            this.btn_DangNap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::_3.PL.Properties.Resources.ho31;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btn_DangNap);
            this.panel2.Controls.Add(this.lb_QuenMk);
            this.panel2.Controls.Add(this.cb_GhiNho);
            this.panel2.Controls.Add(this.tb_MatKhau);
            this.panel2.Controls.Add(this.tb_Email);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 450);
            this.panel2.TabIndex = 1;
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.Location = new System.Drawing.Point(62, 183);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.PlaceholderText = "Email";
            this.tb_Email.Size = new System.Drawing.Size(352, 34);
            this.tb_Email.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::_3.PL.Properties.Resources.giohang;
            this.pictureBox2.Location = new System.Drawing.Point(145, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_MatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_MatKhau.Location = new System.Drawing.Point(62, 244);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PlaceholderText = "Mật khẩu";
            this.tb_MatKhau.Size = new System.Drawing.Size(352, 34);
            this.tb_MatKhau.TabIndex = 2;
            // 
            // cb_GhiNho
            // 
            this.cb_GhiNho.AutoSize = true;
            this.cb_GhiNho.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_GhiNho.Location = new System.Drawing.Point(62, 293);
            this.cb_GhiNho.Name = "cb_GhiNho";
            this.cb_GhiNho.Size = new System.Drawing.Size(93, 27);
            this.cb_GhiNho.TabIndex = 3;
            this.cb_GhiNho.Text = "Ghi nhớ";
            this.cb_GhiNho.UseVisualStyleBackColor = true;
            // 
            // lb_QuenMk
            // 
            this.lb_QuenMk.AutoSize = true;
            this.lb_QuenMk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lb_QuenMk.Location = new System.Drawing.Point(276, 297);
            this.lb_QuenMk.Name = "lb_QuenMk";
            this.lb_QuenMk.Size = new System.Drawing.Size(138, 23);
            this.lb_QuenMk.TabIndex = 4;
            this.lb_QuenMk.Text = "Quên mật khẩu?";
            // 
            // btn_DangNap
            // 
            this.btn_DangNap.BackColor = System.Drawing.Color.Cyan;
            this.btn_DangNap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangNap.Location = new System.Drawing.Point(62, 346);
            this.btn_DangNap.Name = "btn_DangNap";
            this.btn_DangNap.Size = new System.Drawing.Size(352, 41);
            this.btn_DangNap.TabIndex = 5;
            this.btn_DangNap.Text = "ĐĂNG NHẬP";
            this.btn_DangNap.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox tb_Email;
        private PictureBox pictureBox2;
        private TextBox tb_MatKhau;
        private Label lb_QuenMk;
        private CheckBox cb_GhiNho;
        private Button btn_DangNap;
    }
}