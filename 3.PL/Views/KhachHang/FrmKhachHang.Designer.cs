namespace _3.PL.Views.KhachHang
{
    partial class FrmKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KH_TK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_KH_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_HovaTen = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbt_KH_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgrid_KH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // btn_KH_TK
            // 
            this.btn_KH_TK.BackColor = System.Drawing.Color.Transparent;
            this.btn_KH_TK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KH_TK.FlatAppearance.BorderSize = 0;
            this.btn_KH_TK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KH_TK.Location = new System.Drawing.Point(0, 137);
            this.btn_KH_TK.Name = "btn_KH_TK";
            this.btn_KH_TK.Size = new System.Drawing.Size(319, 40);
            this.btn_KH_TK.TabIndex = 1;
            this.btn_KH_TK.Text = "Tìm Kiếm";
            this.btn_KH_TK.UseVisualStyleBackColor = false;
            this.btn_KH_TK.Click += new System.EventHandler(this.btn_KH_TK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btn_KH_Them);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.btn_KH_TK);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 866);
            this.panel2.TabIndex = 1;
            // 
            // btn_KH_Them
            // 
            this.btn_KH_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_KH_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KH_Them.FlatAppearance.BorderSize = 0;
            this.btn_KH_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KH_Them.Location = new System.Drawing.Point(0, 177);
            this.btn_KH_Them.Name = "btn_KH_Them";
            this.btn_KH_Them.Size = new System.Drawing.Size(319, 40);
            this.btn_KH_Them.TabIndex = 51;
            this.btn_KH_Them.Text = "Thêm";
            this.btn_KH_Them.UseVisualStyleBackColor = false;
            this.btn_KH_Them.Click += new System.EventHandler(this.btn_KH_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_Ma);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_HovaTen);
            this.groupBox3.Controls.Add(this.txt_diaChi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_sdt);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 203);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(141, 27);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(138, 27);
            this.txt_Ma.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Họ Và Tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Địa chỉ";
            // 
            // txt_HovaTen
            // 
            this.txt_HovaTen.Location = new System.Drawing.Point(141, 72);
            this.txt_HovaTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HovaTen.Name = "txt_HovaTen";
            this.txt_HovaTen.Size = new System.Drawing.Size(138, 27);
            this.txt_HovaTen.TabIndex = 3;
            this.txt_HovaTen.Leave += new System.EventHandler(this.txt_HovaTen_Leave);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(141, 160);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(138, 27);
            this.txt_diaChi.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "SDT";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(141, 116);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(138, 27);
            this.txt_sdt.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.tbt_KH_TK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // tbt_KH_TK
            // 
            this.tbt_KH_TK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_KH_TK.Location = new System.Drawing.Point(0, 86);
            this.tbt_KH_TK.Name = "tbt_KH_TK";
            this.tbt_KH_TK.Size = new System.Drawing.Size(316, 34);
            this.tbt_KH_TK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo Mã Hoặc Tên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.Dgrid_KH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(319, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 866);
            this.panel3.TabIndex = 2;
            // 
            // Dgrid_KH
            // 
            this.Dgrid_KH.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Dgrid_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgrid_KH.Location = new System.Drawing.Point(0, 0);
            this.Dgrid_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgrid_KH.Name = "Dgrid_KH";
            this.Dgrid_KH.RowHeadersWidth = 51;
            this.Dgrid_KH.RowTemplate.Height = 25;
            this.Dgrid_KH.Size = new System.Drawing.Size(851, 866);
            this.Dgrid_KH.TabIndex = 47;
            this.Dgrid_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_KH_CellClick);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1170, 944);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btn_KH_TK;
        private TextBox tbt_KH_TK;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txt_Ma;
        private Label label5;
        private Label label11;
        private TextBox txt_HovaTen;
        private TextBox txt_diaChi;
        private Label label9;
        private TextBox txt_sdt;
        private DataGridView Dgrid_KH;
        private Button btn_KH_Them;
    }
}