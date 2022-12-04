using _1.DAL.Entities;
using _2.BUS.Services.SanPhams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.SanPham
{
    public partial class FrmMauSac : Form
    {
        IMauSacServices _IMauSacSV;
        MauSac _ms;
        public FrmMauSac()
        {
            InitializeComponent();
            _IMauSacSV = new MauSacServices();
            _ms = new MauSac();
            LoadData();
        }
        private void LoadData()
        {
            dtg_MauSac_Show.ColumnCount = 3;
            dtg_MauSac_Show.Rows.Clear();
            dtg_MauSac_Show.Columns[0].Name = "ID";
            dtg_MauSac_Show.Columns[0].Visible = false;
            dtg_MauSac_Show.Columns[1].Name = "Tên Màu Sắc";
            dtg_MauSac_Show.Columns[2].Name = "Mã Màu Sắc";
            foreach (var a in _IMauSacSV.GetAll())
            {
                dtg_MauSac_Show.Rows.Add(a.Id, a.TenMs, a.MaMs);
            }
        }
        private void LoadData( string input)
        {
            dtg_MauSac_Show.ColumnCount = 3;
            dtg_MauSac_Show.Rows.Clear();
            dtg_MauSac_Show.Columns[0].Name = "ID";
            dtg_MauSac_Show.Columns[0].Visible = false;
            dtg_MauSac_Show.Columns[1].Name = "Tên Màu Sắc";
            dtg_MauSac_Show.Columns[2].Name = "Mã Màu Sắc";
            foreach (var a in _IMauSacSV.GetAll(input))
            {
                dtg_MauSac_Show.Rows.Add(a.Id, a.TenMs, a.MaMs);
            }
        }
        private void Reset()
        {
            LoadData();
            _ms = null;
            tb_TenMauSac.Text = "";
            tb_maMauSac.Text = "";
        }

        private void btn_MauSac_Them_Click(object sender, EventArgs e)
        {
            if (tb_TenMauSac.Text == "" || tb_maMauSac.Text == "")
            {
                MessageBox.Show("Không được để thuộc tính trống");
            }
            else
            {
                var a = new MauSac()
                {
                    Id = new Guid(),
                    TenMs = tb_TenMauSac.Text,
                    MaMs = tb_maMauSac.Text,
                };
                _IMauSacSV.Add(a);
                MessageBox.Show("Thêm màu sắc thành công");
                Reset();
            }
        }

        private void btn_MauSac_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                _IMauSacSV.Remove(_ms);
                MessageBox.Show("Xóa màu sắc thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác xóa");
            }
        }

        private void btn_MauSac_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb_TenMauSac.Text == "" || tb_maMauSac.Text == "")
            {
                MessageBox.Show("Không được để thuộc tính trống");
            }
            else if (dg == DialogResult.Yes)
            {
                _ms.TenMs = tb_TenMauSac.Text;
                _ms.MaMs = tb_maMauSac.Text;
                _IMauSacSV.Update(_ms);
                MessageBox.Show("Sửa màu sắc thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác sửa");
            }
        }

        private void btn_ShowMauSac_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_MauSac_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tb_MauSac_TimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadData(tb_MauSac_TimKiem.Text);
        }

        private void dtg_MauSac_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_MauSac_Show.Rows[e.RowIndex];
                _ms = _IMauSacSV.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_TenMauSac.Text = r.Cells[1].Value.ToString();
                tb_maMauSac.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}   
