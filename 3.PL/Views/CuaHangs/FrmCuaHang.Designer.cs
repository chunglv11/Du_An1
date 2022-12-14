namespace _3.PL.Views.CuaHangs
{
    partial class FrmCuaHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Ma = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ThanhPho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_QuocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_ShowCuaHang = new System.Windows.Forms.DataGridView();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_CuaHang = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowCuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã cửa hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 74);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "CỬA HÀNG";
            // 
            // tb_Ma
            // 
            this.tb_Ma.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Ma.Location = new System.Drawing.Point(139, 89);
            this.tb_Ma.Name = "tb_Ma";
            this.tb_Ma.Size = new System.Drawing.Size(352, 38);
            this.tb_Ma.TabIndex = 2;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_DiaChi.Location = new System.Drawing.Point(139, 216);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(352, 38);
            this.tb_DiaChi.TabIndex = 4;
            this.tb_DiaChi.Leave += new System.EventHandler(this.tb_DiaChi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // tb_ThanhPho
            // 
            this.tb_ThanhPho.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_ThanhPho.Location = new System.Drawing.Point(139, 279);
            this.tb_ThanhPho.Name = "tb_ThanhPho";
            this.tb_ThanhPho.Size = new System.Drawing.Size(352, 38);
            this.tb_ThanhPho.TabIndex = 6;
            this.tb_ThanhPho.Leave += new System.EventHandler(this.tb_ThanhPho_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành phố";
            // 
            // tb_QuocGia
            // 
            this.tb_QuocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_QuocGia.Location = new System.Drawing.Point(139, 337);
            this.tb_QuocGia.Name = "tb_QuocGia";
            this.tb_QuocGia.Size = new System.Drawing.Size(352, 38);
            this.tb_QuocGia.TabIndex = 8;
            this.tb_QuocGia.Leave += new System.EventHandler(this.tb_QuocGia_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quốc gia";
            // 
            // tb_Ten
            // 
            this.tb_Ten.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Ten.Location = new System.Drawing.Point(139, 146);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(352, 38);
            this.tb_Ten.TabIndex = 10;
            this.tb_Ten.TextChanged += new System.EventHandler(this.tb_Ten_TextChanged);
            this.tb_Ten.Leave += new System.EventHandler(this.tb_Ten_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên cửa hàng";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Location = new System.Drawing.Point(12, 485);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(147, 49);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Location = new System.Drawing.Point(177, 485);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(147, 49);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Location = new System.Drawing.Point(344, 485);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(147, 49);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgv_ShowCuaHang
            // 
            this.dgv_ShowCuaHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ShowCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowCuaHang.Location = new System.Drawing.Point(636, 89);
            this.dgv_ShowCuaHang.Name = "dgv_ShowCuaHang";
            this.dgv_ShowCuaHang.RowHeadersWidth = 51;
            this.dgv_ShowCuaHang.RowTemplate.Height = 29;
            this.dgv_ShowCuaHang.Size = new System.Drawing.Size(486, 364);
            this.dgv_ShowCuaHang.TabIndex = 14;
            this.dgv_ShowCuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShowCuaHang_CellClick);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(139, 409);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(352, 27);
            this.tb_TimKiem.TabIndex = 30;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // lbl_CuaHang
            // 
            this.lbl_CuaHang.AutoSize = true;
            this.lbl_CuaHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CuaHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CuaHang.Location = new System.Drawing.Point(13, 416);
            this.lbl_CuaHang.Name = "lbl_CuaHang";
            this.lbl_CuaHang.Size = new System.Drawing.Size(78, 20);
            this.lbl_CuaHang.TabIndex = 31;
            this.lbl_CuaHang.Text = "Tìm kiếm:";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(517, 485);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(147, 49);
            this.btn_reset.TabIndex = 32;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // FrmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1180, 671);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.lbl_CuaHang);
            this.Controls.Add(this.dgv_ShowCuaHang);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_QuocGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ThanhPho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Ma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuaHang";
            this.Text = "FrmCuaHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowCuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox tb_Ma;
        private TextBox tb_DiaChi;
        private Label label3;
        private TextBox tb_ThanhPho;
        private Label label4;
        private TextBox tb_QuocGia;
        private Label label5;
        private TextBox tb_Ten;
        private Label label6;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private DataGridView dgv_ShowCuaHang;
        private TextBox tb_TimKiem;
        private Label lbl_CuaHang;
        private Button btn_reset;
    }
}