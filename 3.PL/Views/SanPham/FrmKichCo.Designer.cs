namespace _3.PL.SanPham
{
    partial class FrmKichCo
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_KichCo_Show = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_KichCo_Xoa = new System.Windows.Forms.Button();
            this.btn_KichCo_Back = new System.Windows.Forms.Button();
            this.btn_KichCo_Sua = new System.Windows.Forms.Button();
            this.btn_ShowKichCo = new System.Windows.Forms.Button();
            this.btn_KichCo_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maKichCo = new System.Windows.Forms.TextBox();
            this.tb_TenKichCo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_KichCo_TimKiem = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KichCo_Show)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label15);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1171, 115);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 60);
            this.label15.TabIndex = 14;
            this.label15.Text = "KichCo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_KichCo_Show);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(583, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 434);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            // 
            // dtg_KichCo_Show
            // 
            this.dtg_KichCo_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_KichCo_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_KichCo_Show.Location = new System.Drawing.Point(3, 34);
            this.dtg_KichCo_Show.Name = "dtg_KichCo_Show";
            this.dtg_KichCo_Show.RowHeadersWidth = 51;
            this.dtg_KichCo_Show.RowTemplate.Height = 29;
            this.dtg_KichCo_Show.Size = new System.Drawing.Size(572, 397);
            this.dtg_KichCo_Show.TabIndex = 17;
            this.dtg_KichCo_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_KichCo_Show_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_KichCo_Xoa);
            this.groupBox1.Controls.Add(this.tb_KichCo_TimKiem);
            this.groupBox1.Controls.Add(this.btn_KichCo_Back);
            this.groupBox1.Controls.Add(this.btn_KichCo_Sua);
            this.groupBox1.Controls.Add(this.btn_ShowKichCo);
            this.groupBox1.Controls.Add(this.btn_KichCo_Them);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 268);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn_KichCo_Xoa
            // 
            this.btn_KichCo_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_KichCo_Xoa.Location = new System.Drawing.Point(366, 42);
            this.btn_KichCo_Xoa.Name = "btn_KichCo_Xoa";
            this.btn_KichCo_Xoa.Size = new System.Drawing.Size(149, 45);
            this.btn_KichCo_Xoa.TabIndex = 26;
            this.btn_KichCo_Xoa.Text = "Xóa";
            this.btn_KichCo_Xoa.UseVisualStyleBackColor = true;
            this.btn_KichCo_Xoa.Click += new System.EventHandler(this.btn_KichCo_Xoa_Click);
            // 
            // btn_KichCo_Back
            // 
            this.btn_KichCo_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KichCo_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_KichCo_Back.Location = new System.Drawing.Point(369, 132);
            this.btn_KichCo_Back.Name = "btn_KichCo_Back";
            this.btn_KichCo_Back.Size = new System.Drawing.Size(146, 43);
            this.btn_KichCo_Back.TabIndex = 0;
            this.btn_KichCo_Back.Text = "Back";
            this.btn_KichCo_Back.UseVisualStyleBackColor = true;
            this.btn_KichCo_Back.Click += new System.EventHandler(this.btn_KichCo_Back_Click);
            // 
            // btn_KichCo_Sua
            // 
            this.btn_KichCo_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_KichCo_Sua.Location = new System.Drawing.Point(189, 42);
            this.btn_KichCo_Sua.Name = "btn_KichCo_Sua";
            this.btn_KichCo_Sua.Size = new System.Drawing.Size(146, 45);
            this.btn_KichCo_Sua.TabIndex = 25;
            this.btn_KichCo_Sua.Text = "Sửa";
            this.btn_KichCo_Sua.UseVisualStyleBackColor = true;
            this.btn_KichCo_Sua.Click += new System.EventHandler(this.btn_KichCo_Sua_Click);
            // 
            // btn_ShowKichCo
            // 
            this.btn_ShowKichCo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowKichCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_ShowKichCo.Location = new System.Drawing.Point(6, 132);
            this.btn_ShowKichCo.Name = "btn_ShowKichCo";
            this.btn_ShowKichCo.Size = new System.Drawing.Size(157, 43);
            this.btn_ShowKichCo.TabIndex = 3;
            this.btn_ShowKichCo.Text = "Hiện Thị";
            this.btn_ShowKichCo.UseVisualStyleBackColor = true;
            this.btn_ShowKichCo.Click += new System.EventHandler(this.btn_ShowKichCo_Click);
            // 
            // btn_KichCo_Them
            // 
            this.btn_KichCo_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KichCo_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_KichCo_Them.Location = new System.Drawing.Point(6, 46);
            this.btn_KichCo_Them.Name = "btn_KichCo_Them";
            this.btn_KichCo_Them.Size = new System.Drawing.Size(157, 43);
            this.btn_KichCo_Them.TabIndex = 2;
            this.btn_KichCo_Them.Text = "Thêm ";
            this.btn_KichCo_Them.UseVisualStyleBackColor = true;
            this.btn_KichCo_Them.Click += new System.EventHandler(this.btn_KichCo_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_maKichCo);
            this.groupBox3.Controls.Add(this.tb_TenKichCo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(6, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 271);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Kích Cỡ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Kích Cỡ";
            // 
            // tb_maKichCo
            // 
            this.tb_maKichCo.Location = new System.Drawing.Point(20, 211);
            this.tb_maKichCo.Name = "tb_maKichCo";
            this.tb_maKichCo.Size = new System.Drawing.Size(496, 34);
            this.tb_maKichCo.TabIndex = 1;
            // 
            // tb_TenKichCo
            // 
            this.tb_TenKichCo.Location = new System.Drawing.Point(20, 86);
            this.tb_TenKichCo.Name = "tb_TenKichCo";
            this.tb_TenKichCo.Size = new System.Drawing.Size(496, 34);
            this.tb_TenKichCo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(210, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tìm kiếm :";
            // 
            // tb_KichCo_TimKiem
            // 
            this.tb_KichCo_TimKiem.Location = new System.Drawing.Point(12, 210);
            this.tb_KichCo_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_KichCo_TimKiem.Name = "tb_KichCo_TimKiem";
            this.tb_KichCo_TimKiem.Size = new System.Drawing.Size(503, 38);
            this.tb_KichCo_TimKiem.TabIndex = 57;
            this.tb_KichCo_TimKiem.TextChanged += new System.EventHandler(this.tb_KichCo_TimKiem_TextChanged);
            // 
            // FrmKichCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 709);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmKichCo";
            this.Text = "FrmKichCo";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KichCo_Show)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label15;
        private GroupBox groupBox2;
        private DataGridView dtg_KichCo_Show;
        private GroupBox groupBox1;
        private Button btn_KichCo_Xoa;
        private Button btn_KichCo_Back;
        private Button btn_KichCo_Sua;
        private Button btn_ShowKichCo;
        private Button btn_KichCo_Them;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private TextBox tb_maKichCo;
        private TextBox tb_TenKichCo;
        private Label label1;
        private TextBox tb_KichCo_TimKiem;
    }
}