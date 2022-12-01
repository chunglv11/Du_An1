namespace _3.PL
{
    partial class FrmSanPham
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
            this.dtg_SanPham_Show = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SanPham_Xoa = new System.Windows.Forms.Button();
            this.btn_SanPham_Back = new System.Windows.Forms.Button();
            this.btn_SanPham_Sua = new System.Windows.Forms.Button();
            this.btn_ShowSanPham = new System.Windows.Forms.Button();
            this.btn_SanPham_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maSanPham = new System.Windows.Forms.TextBox();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanPham_Show)).BeginInit();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1182, 115);
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
            this.label15.Size = new System.Drawing.Size(230, 60);
            this.label15.TabIndex = 14;
            this.label15.Text = "Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_SanPham_Show);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(585, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 434);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            // 
            // dtg_SanPham_Show
            // 
            this.dtg_SanPham_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SanPham_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_SanPham_Show.Location = new System.Drawing.Point(3, 34);
            this.dtg_SanPham_Show.Name = "dtg_SanPham_Show";
            this.dtg_SanPham_Show.RowHeadersWidth = 51;
            this.dtg_SanPham_Show.RowTemplate.Height = 29;
            this.dtg_SanPham_Show.Size = new System.Drawing.Size(572, 397);
            this.dtg_SanPham_Show.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SanPham_Xoa);
            this.groupBox1.Controls.Add(this.btn_SanPham_Back);
            this.groupBox1.Controls.Add(this.btn_SanPham_Sua);
            this.groupBox1.Controls.Add(this.btn_ShowSanPham);
            this.groupBox1.Controls.Add(this.btn_SanPham_Them);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 197);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn_SanPham_Xoa
            // 
            this.btn_SanPham_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_SanPham_Xoa.Location = new System.Drawing.Point(190, 46);
            this.btn_SanPham_Xoa.Name = "btn_SanPham_Xoa";
            this.btn_SanPham_Xoa.Size = new System.Drawing.Size(149, 45);
            this.btn_SanPham_Xoa.TabIndex = 26;
            this.btn_SanPham_Xoa.Text = "Xóa";
            this.btn_SanPham_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham_Back
            // 
            this.btn_SanPham_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SanPham_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_SanPham_Back.Location = new System.Drawing.Point(369, 132);
            this.btn_SanPham_Back.Name = "btn_SanPham_Back";
            this.btn_SanPham_Back.Size = new System.Drawing.Size(146, 43);
            this.btn_SanPham_Back.TabIndex = 0;
            this.btn_SanPham_Back.Text = "Back";
            this.btn_SanPham_Back.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham_Sua
            // 
            this.btn_SanPham_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_SanPham_Sua.Location = new System.Drawing.Point(369, 46);
            this.btn_SanPham_Sua.Name = "btn_SanPham_Sua";
            this.btn_SanPham_Sua.Size = new System.Drawing.Size(146, 45);
            this.btn_SanPham_Sua.TabIndex = 25;
            this.btn_SanPham_Sua.Text = "Sửa";
            this.btn_SanPham_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_ShowSanPham
            // 
            this.btn_ShowSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_ShowSanPham.Location = new System.Drawing.Point(6, 132);
            this.btn_ShowSanPham.Name = "btn_ShowSanPham";
            this.btn_ShowSanPham.Size = new System.Drawing.Size(157, 43);
            this.btn_ShowSanPham.TabIndex = 3;
            this.btn_ShowSanPham.Text = "Hiện Thị";
            this.btn_ShowSanPham.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham_Them
            // 
            this.btn_SanPham_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SanPham_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(164)))), ((int)(((byte)(78)))));
            this.btn_SanPham_Them.Location = new System.Drawing.Point(6, 46);
            this.btn_SanPham_Them.Name = "btn_SanPham_Them";
            this.btn_SanPham_Them.Size = new System.Drawing.Size(157, 43);
            this.btn_SanPham_Them.TabIndex = 2;
            this.btn_SanPham_Them.Text = "Thêm ";
            this.btn_SanPham_Them.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_maSanPham);
            this.groupBox3.Controls.Add(this.tb_TenSanPham);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(8, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 271);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // tb_maSanPham
            // 
            this.tb_maSanPham.Location = new System.Drawing.Point(20, 211);
            this.tb_maSanPham.Name = "tb_maSanPham";
            this.tb_maSanPham.Size = new System.Drawing.Size(496, 34);
            this.tb_maSanPham.TabIndex = 1;
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.Location = new System.Drawing.Point(20, 86);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(496, 34);
            this.tb_TenSanPham.TabIndex = 0;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanPham_Show)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label15;
        private GroupBox groupBox2;
        private DataGridView dtg_SanPham_Show;
        private GroupBox groupBox1;
        private Button btn_SanPham_Xoa;
        private Button btn_SanPham_Back;
        private Button btn_SanPham_Sua;
        private Button btn_ShowSanPham;
        private Button btn_SanPham_Them;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private TextBox tb_maSanPham;
        private TextBox tb_TenSanPham;
    }
}