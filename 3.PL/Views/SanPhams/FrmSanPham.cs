using _2.BUS.Services.SanPhams;
using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.SanPhams
{
    public partial class FrmSanPham : Form
    {
        ISanPhamServices _ISanPhamSV;
        _1.DAL.Entities.SanPham _sp;
        Guid _id;
        public FrmSanPham()
        {
            InitializeComponent();
            _ISanPhamSV = new SanPhamServices();
            LoadData();
        }
        public void LoadData()
        {
            dtg_SanPham_Show.ColumnCount = 3;
            dtg_SanPham_Show.Columns[0].Name = "Id";
            dtg_SanPham_Show.Columns[0].Visible = false;
            dtg_SanPham_Show.Columns[1].Name = "Tên SP";
            dtg_SanPham_Show.Columns[2].Name = "Mã SP";
            dtg_SanPham_Show.Rows.Clear();
            foreach (var x in _ISanPhamSV.GetAll())
            {
                dtg_SanPham_Show.Rows.Add(x.Id, x.TenSp, x.MaSp);
            }
        }

        public void LoadDataCheck(string input)
        {
            dtg_SanPham_Show.ColumnCount = 3;
            dtg_SanPham_Show.Columns[0].Name = "Id";
            dtg_SanPham_Show.Columns[0].Visible = false;
            dtg_SanPham_Show.Columns[1].Name = "Tên SP";
            dtg_SanPham_Show.Columns[2].Name = "Mã SP";
            dtg_SanPham_Show.Rows.Clear();
            foreach (var x in _ISanPhamSV.GetAll(input))
            {
                dtg_SanPham_Show.Rows.Add(x.Id, x.TenSp, x.MaSp);
            }
        }
        public void Reset()
        {
            LoadData();
            _sp = null;
            tb_TenSanPham.Text = "";
            tb_maSanPham.Text = "";
        }

        private void btn_SanPham_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maSanPham.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã dòng sản phẩm ");
                }
                else if (_ISanPhamSV.GetAll().Any(c => c.MaSp == tb_maSanPham.Text))
                {
                    MessageBox.Show("Mã sản phẩm này đã tồn tại");
                }
                else
                {
                    var sp = new _1.DAL.Entities.SanPham()
                    {
                        Id = new Guid(),
                        TenSp = tb_TenSanPham.Text,
                        MaSp = tb_maSanPham.Text,
                    };
                    _ISanPhamSV.add(sp);
                    MessageBox.Show("Thêm dòng sản phẩm thành công");
                    Reset();

                }
            }
        }

        private void btn_SanPham_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maSanPham.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm");
                }
                else if (_sp == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                }
                else
                {
                    if (_sp.MaSp == tb_maSanPham.Text || (_sp.MaSp != tb_maSanPham.Text && _ISanPhamSV.GetAll().FirstOrDefault(c => c.MaSp == tb_maSanPham.Text) == null))
                    {
                        _sp.TenSp = tb_TenSanPham.Text;
                        _sp.MaSp = tb_maSanPham.Text;
                        _ISanPhamSV.update(_sp);
                        MessageBox.Show("Sửa sản phẩm thành công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại");
                    }
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_SanPham_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_sp == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                }
                else
                {
                    _ISanPhamSV.delete(_sp);
                    MessageBox.Show("Xóa dòng sản phẩm thành công");
                    Reset();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_ShowSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btn_SanPham_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_SanPham_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataCheck(tb_SanPham_TimKiem.Text);
        }

        private void dtg_SanPham_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_SanPham_Show.Rows[e.RowIndex];
                _sp = _ISanPhamSV.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_TenSanPham.Text = r.Cells[1].Value.ToString();
                tb_maSanPham.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}
