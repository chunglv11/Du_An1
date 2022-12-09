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

namespace _3.PL.Views.SanPhams
{
    public partial class FrmNSX : Form
    {
        INSXServices _INSXSV;
        Nsx _nsx;
        public FrmNSX()
        {
            InitializeComponent();
            _INSXSV = new NSXServices();
            _nsx = new Nsx();
            LoadData();
        }

        public void LoadData()
        {
            dtg_NSX_Show.ColumnCount = 3;
            dtg_NSX_Show.Columns[0].Name = "Id";
            dtg_NSX_Show.Columns[0].Visible = false;
            dtg_NSX_Show.Columns[1].Name = " Tên NSX";
            dtg_NSX_Show.Columns[2].Name = " Mã NSX";
            dtg_NSX_Show.Rows.Clear();
            var lstNsx = _INSXSV.GetNsx();
            if (tb_NSX_TimKiem.Text != "")
            {
                lstNsx = lstNsx.Where(c => c.TenNsx.ToLower().Contains(tb_NSX_TimKiem.Text.ToLower()) || c.MaNsx.ToLower().Contains(tb_NSX_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstNsx)
            {
                dtg_NSX_Show.Rows.Add(x.Id, x.TenNsx, x.MaNsx);
            }
        }
        public void resetForm()
        {
            LoadData();
            _nsx = null;
            tb_TenNSX.Text = "";
            tb_maNSX.Text = "";
        }

        private void btn_NSX_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm nhà sản xuất này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maNSX.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhà sản xuất ");
                }
                else if (_INSXSV.GetNsx().Any(c => c.MaNsx == tb_maNSX.Text))
                {
                    MessageBox.Show("Mã nhà sản xuất này đã tồn tại");
                }
                else
                {
                    var nsx = new Nsx()
                    {
                        Id = new Guid(),
                        TenNsx = tb_TenNSX.Text,
                        MaNsx = tb_maNSX.Text,
                    };
                    _INSXSV.add(nsx);
                    MessageBox.Show("Thêm nhà sản xuất thành công");
                    resetForm();

                }
            }
        }

        private void btn_NSX_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa nhà sản xuất này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maNSX.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhà sản xuất");
                }
                else if (_nsx == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà sản xuất");
                }
                else
                {
                    if (_nsx.MaNsx == tb_maNSX.Text || (_nsx.MaNsx != tb_maNSX.Text && _INSXSV.GetNsx().FirstOrDefault(c => c.MaNsx == tb_maNSX.Text) == null))
                    {
                        _nsx.TenNsx = tb_TenNSX.Text;
                        _nsx.MaNsx = tb_maNSX.Text;
                        _INSXSV.update(_nsx);
                        MessageBox.Show("Sửa nhà sản xuất thành công");
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhà sản xuất đã tồn tại");
                    }
                }
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btn_NSX_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà sản xuất này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_nsx == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà sản xuất ");
                }
                else
                {
                    _INSXSV.delete(_nsx);
                    MessageBox.Show("Xóa nhà sản xuất thành công");
                    resetForm();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_ShowNSX_Click(object sender, EventArgs e)
        {

        }

        private void btn_NSX_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_NSX_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_NSX_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_NSX_Show.Rows[e.RowIndex];
                _nsx = _INSXSV.GetNsx().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_TenNSX.Text = r.Cells[1].Value.ToString();
                tb_maNSX.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}
