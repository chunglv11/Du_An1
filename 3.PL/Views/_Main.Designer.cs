namespace _3.PL.Views
{
    partial class _Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Main));
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.panel_Desk = new System.Windows.Forms.Panel();
            this.ptb_Desktop = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BanHang = new System.Windows.Forms.Button();
            this.ptb_Avata = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_HoTenUser = new System.Windows.Forms.Label();
            this.lb_ChucVuUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.panel_Desktop.SuspendLayout();
            this.panel_Desk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Desktop)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avata)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Controls.Add(this.panel_Desk);
            this.panel_Desktop.Controls.Add(this.panel1);
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(0, 0);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(1433, 745);
            this.panel_Desktop.TabIndex = 1;
            // 
            // panel_Desk
            // 
            this.panel_Desk.Controls.Add(this.ptb_Desktop);
            this.panel_Desk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desk.Location = new System.Drawing.Point(320, 0);
            this.panel_Desk.Name = "panel_Desk";
            this.panel_Desk.Size = new System.Drawing.Size(1113, 745);
            this.panel_Desk.TabIndex = 5;
            // 
            // ptb_Desktop
            // 
            this.ptb_Desktop.BackColor = System.Drawing.Color.White;
            this.ptb_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Desktop.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Desktop.Image")));
            this.ptb_Desktop.Location = new System.Drawing.Point(0, 0);
            this.ptb_Desktop.Name = "ptb_Desktop";
            this.ptb_Desktop.Size = new System.Drawing.Size(1113, 745);
            this.ptb_Desktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Desktop.TabIndex = 3;
            this.ptb_Desktop.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ptb_Avata);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 745);
            this.panel1.TabIndex = 4;
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_BanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BanHang.FlatAppearance.BorderSize = 0;
            this.btn_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BanHang.Location = new System.Drawing.Point(0, 0);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Size = new System.Drawing.Size(320, 65);
            this.btn_BanHang.TabIndex = 1;
            this.btn_BanHang.Text = "Bán Hàng";
            this.btn_BanHang.UseVisualStyleBackColor = false;
            // 
            // ptb_Avata
            // 
            this.ptb_Avata.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_Avata.Image = global::_3.PL.Properties.Resources.ho2;
            this.ptb_Avata.Location = new System.Drawing.Point(0, 0);
            this.ptb_Avata.Name = "ptb_Avata";
            this.ptb_Avata.Size = new System.Drawing.Size(320, 191);
            this.ptb_Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Avata.TabIndex = 0;
            this.ptb_Avata.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_ChucVuUser);
            this.panel2.Controls.Add(this.lb_HoTenUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 94);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ:";
            // 
            // lb_HoTenUser
            // 
            this.lb_HoTenUser.AutoSize = true;
            this.lb_HoTenUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_HoTenUser.Location = new System.Drawing.Point(104, 14);
            this.lb_HoTenUser.Name = "lb_HoTenUser";
            this.lb_HoTenUser.Size = new System.Drawing.Size(56, 25);
            this.lb_HoTenUser.TabIndex = 2;
            this.lb_HoTenUser.Text = "...........";
            // 
            // lb_ChucVuUser
            // 
            this.lb_ChucVuUser.AutoSize = true;
            this.lb_ChucVuUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ChucVuUser.Location = new System.Drawing.Point(104, 48);
            this.lb_ChucVuUser.Name = "lb_ChucVuUser";
            this.lb_ChucVuUser.Size = new System.Drawing.Size(56, 25);
            this.lb_ChucVuUser.TabIndex = 3;
            this.lb_ChucVuUser.Text = "...........";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_DangXuat);
            this.panel3.Controls.Add(this.btn_ThongKe);
            this.panel3.Controls.Add(this.btn_KhachHang);
            this.panel3.Controls.Add(this.btn_NhanVien);
            this.panel3.Controls.Add(this.btn_SanPham);
            this.panel3.Controls.Add(this.btn_HoaDon);
            this.panel3.Controls.Add(this.btn_BanHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 460);
            this.panel3.TabIndex = 8;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_HoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 65);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(320, 65);
            this.btn_HoaDon.TabIndex = 2;
            this.btn_HoaDon.Text = "Hoá Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_SanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SanPham.Location = new System.Drawing.Point(0, 130);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(320, 65);
            this.btn_SanPham.TabIndex = 3;
            this.btn_SanPham.Text = "Sản phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = false;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 195);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(320, 65);
            this.btn_NhanVien.TabIndex = 4;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_KhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 260);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(320, 65);
            this.btn_KhachHang.TabIndex = 5;
            this.btn_KhachHang.Text = "Khách Hàng";
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 325);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(320, 65);
            this.btn_ThongKe.TabIndex = 6;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 390);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(320, 65);
            this.btn_DangXuat.TabIndex = 7;
            this.btn_DangXuat.Text = "Bán Hàng";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            // 
            // _Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 745);
            this.Controls.Add(this.panel_Desktop);
            this.Name = "_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Desktop.ResumeLayout(false);
            this.panel_Desk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Desktop)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_Desktop;
        private PictureBox ptb_Desktop;
        private Panel panel_Desk;
        private Panel panel1;
        private Button btn_BanHang;
        private PictureBox ptb_Avata;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label lb_ChucVuUser;
        private Label lb_HoTenUser;
        private Button btn_DangXuat;
        private Button btn_ThongKe;
        private Button btn_KhachHang;
        private Button btn_NhanVien;
        private Button btn_SanPham;
        private Button btn_HoaDon;
    }
}