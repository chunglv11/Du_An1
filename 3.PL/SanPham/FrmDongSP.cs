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

namespace _3.PL.SanPham
{
    public partial class FrmDongSP : Form
    {
        IDongSpServices _IDongSPSV;
        DongSp _DongSP;
        public FrmDongSP()
        {
            InitializeComponent();
            _IDongSPSV = new DongSpServices();
            _DongSP = new DongSp();
            LoadData();
        }
        private void LoadData()
        {
            dtg_DongSP_Show.ColumnCount = 3;
            dtg_DongSP_Show.Rows.Clear();
            dtg_DongSP_Show.Columns[0].Name = "ID";
            dtg_DongSP_Show.Columns[0].Visible = false;
            dtg_DongSP_Show.Columns[1].Name = "Tên";
            dtg_DongSP_Show.Columns[2].Name = "Mã";
            foreach (var a in _IDongSPSV.GetAll())
            {
                dtg_DongSP_Show.Rows.Add(a.Id, a.MaDsp, a.TenDsp);
            }
        }
        private void Reset()
        {
            LoadData();
            _DongSP = null;
            tb_TenDongSP.Text = "";
            tb_maDongSP.Text = "";
        }
        private void LoadDataCheck(string input)
        {
            dtg_DongSP_Show.ColumnCount = 3;
            dtg_DongSP_Show.Rows.Clear();
            dtg_DongSP_Show.Columns[0].Name = "ID";
            dtg_DongSP_Show.Columns[0].Visible = false;
            dtg_DongSP_Show.Columns[1].Name = "Tên";
            dtg_DongSP_Show.Columns[2].Name = "Mã";
            foreach (var a in _IDongSPSV.GetAll(input))
            {
                dtg_DongSP_Show.Rows.Add(a.Id, a.MaDsp, a.TenDsp);
            }
        }
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataCheck(tb_DongSP_TimKIem.Text);
        }

        private void btn_DongSP_Them_Click(object sender, EventArgs e)
        {
            if (tb_TenDongSP.Text == "" || tb_maDongSP.Text == "")
            {
                MessageBox.Show("Không được để thuộc tính trống");
            }
            else
            {
                var a = new DongSp()
                {
                    Id = new Guid(),
                    TenDsp = tb_TenDongSP.Text,
                    MaDsp = tb_maDongSP.Text,                  
                };
                _IDongSPSV.Add(a);
                MessageBox.Show("Thêm dòng sản phẩm thành công");
                Reset();
            }
        }

        private void btn_DongSP_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                _IDongSPSV.Remove(_DongSP);
                MessageBox.Show("Xóa dòng sản phẩm thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác xóa");
            }
        }

        private void btn_DongSP_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb_TenDongSP.Text == "" || tb_maDongSP.Text == "")
            {
                MessageBox.Show("Không được để thuộc tính trống");
            }
            else if (dg == DialogResult.Yes)
            {
                _DongSP.TenDsp = tb_TenDongSP.Text;
                _DongSP.MaDsp = tb_maDongSP.Text;
                _IDongSPSV.Update(_DongSP);
                MessageBox.Show("Sửa dòng sản phẩm thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác sửa");
            }
        }

        private void btn_DongSP_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_DongSP_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_DongSP_Show.Rows[e.RowIndex];
                _DongSP = _IDongSPSV.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_TenDongSP.Text = r.Cells[1].Value.ToString();
                tb_maDongSP.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}
