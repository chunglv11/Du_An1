namespace _3.PL.Views.HoaDon
{
    partial class FrmHoaDon
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_hdct = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_HD_TimKiem = new System.Windows.Forms.Button();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.dgrid_hoadon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1559, 944);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 547);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1559, 397);
            this.panel4.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_hdct);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1559, 397);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoá đơn chi tiết";
            // 
            // dgrid_hdct
            // 
            this.dgrid_hdct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hdct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_hdct.Location = new System.Drawing.Point(3, 30);
            this.dgrid_hdct.Name = "dgrid_hdct";
            this.dgrid_hdct.RowHeadersWidth = 51;
            this.dgrid_hdct.RowTemplate.Height = 29;
            this.dgrid_hdct.Size = new System.Drawing.Size(1553, 364);
            this.dgrid_hdct.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1559, 478);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_HD_TimKiem);
            this.groupBox1.Controls.Add(this.txt_TK);
            this.groupBox1.Controls.Add(this.dgrid_hoadon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1559, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoá đơn";
            // 
            // btn_HD_TimKiem
            // 
            this.btn_HD_TimKiem.Location = new System.Drawing.Point(304, 53);
            this.btn_HD_TimKiem.Name = "btn_HD_TimKiem";
            this.btn_HD_TimKiem.Size = new System.Drawing.Size(127, 34);
            this.btn_HD_TimKiem.TabIndex = 2;
            this.btn_HD_TimKiem.Text = "Tìm kiếm";
            this.btn_HD_TimKiem.UseVisualStyleBackColor = true;
            this.btn_HD_TimKiem.Click += new System.EventHandler(this.btn_HD_TimKiem_Click);
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(22, 53);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(253, 34);
            this.txt_TK.TabIndex = 1;
            // 
            // dgrid_hoadon
            // 
            this.dgrid_hoadon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_hoadon.Location = new System.Drawing.Point(3, 105);
            this.dgrid_hoadon.Name = "dgrid_hoadon";
            this.dgrid_hoadon.RowHeadersWidth = 51;
            this.dgrid_hoadon.RowTemplate.Height = 29;
            this.dgrid_hoadon.Size = new System.Drawing.Size(1553, 370);
            this.dgrid_hoadon.TabIndex = 0;
            this.dgrid_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_hoadon_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1559, 69);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1559, 944);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private GroupBox groupBox2;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dgrid_hoadon;
        private TextBox txt_TK;
        private Button btn_HD_TimKiem;
        private DataGridView dgrid_hdct;
    }
}