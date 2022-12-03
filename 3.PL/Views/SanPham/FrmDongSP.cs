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
            dtg_DongSP_Show.Columns[1].Name = "Mã Dòng SP";
            dtg_DongSP_Show.Columns[2].Name = "Tên Dòng SP";
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
            dtg_DongSP_Show.Columns[1].Name = "Mã Dòng SP";
            dtg_DongSP_Show.Columns[2].Name = "Tên Dòng SP";
            foreach (var a in _IDongSPSV.GetAll(input))
            {
                dtg_DongSP_Show.Rows.Add(a.Id, a.MaDsp, a.TenDsp);
            }
        }
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataCheck(tb_DongSP_TimKiem.Text);
        }

        private void btn_DongSP_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm dòng sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maDongSP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã dòng sản phẩm ");
                }
                else if (_IDongSPSV.GetAll().Any(c => c.MaDsp == tb_maDongSP.Text))
                {
                    MessageBox.Show("Mã dòng sản phẩm này đã tồn tại");
                }
                else
                {
                    var dsp = new DongSp()
                    {
                        Id = new Guid(),
                        TenDsp = tb_TenDongSP.Text,
                        MaDsp  = tb_maDongSP.Text,
                    };
                    _IDongSPSV.Add(dsp);
                    MessageBox.Show("Thêm dòng sản phẩm thành công");
                    Reset();

                }
            }
        }

        private void btn_DongSP_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_DongSP == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng sản phẩm");
                }
                else
                {
                    _IDongSPSV.Remove(_DongSP);
                    MessageBox.Show("Xóa dòng sản phẩm thành công");
                    Reset();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_DongSP_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa dòng sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maDongSP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã dòng sản phẩm");
                }
                else if (_DongSP == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng sản phẩm");
                }
                else
                {
                    if (_DongSP.MaDsp == tb_maDongSP.Text || (_DongSP.MaDsp != tb_maDongSP.Text && _IDongSPSV.GetAll().FirstOrDefault(c => c.MaDsp == tb_maDongSP.Text) == null))
                    {
                        _DongSP.TenDsp = tb_TenDongSP.Text;
                        _DongSP.MaDsp = tb_maDongSP.Text;
                        _IDongSPSV.Update(_DongSP);
                        MessageBox.Show("Sửa dòng sản phẩm thành công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Mã dòng sản phẩm đã tồn tại");
                    }
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
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
