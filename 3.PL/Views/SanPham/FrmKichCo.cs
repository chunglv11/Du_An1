using _1.DAL.Entities;
using _2.BUS.Services.SanPhams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.SanPham
{
    public partial class FrmKichCo : Form
    {
        IKichCoServices _IKichCoSV;
        KichCo _kc;
        public FrmKichCo()
        {
            InitializeComponent();
            _IKichCoSV = new KichCoServices();
            _kc = new KichCo();
            LoadData();
        }
        public void LoadData()
        {
            dtg_KichCo_Show.ColumnCount = 3;
            dtg_KichCo_Show.Columns[0].Name = "Id";
            dtg_KichCo_Show.Columns[0].Visible = false;
            dtg_KichCo_Show.Columns[1].Name = " Tên Kích Cỡ ";
            dtg_KichCo_Show.Columns[2].Name = "Mã Kích Cỡ ";
            dtg_KichCo_Show.Rows.Clear();
            var lstKichCo = _IKichCoSV.GetKichCo();
            if (tb_KichCo_TimKiem.Text != "")
            {
                lstKichCo = lstKichCo.Where(c => c.TenKc.ToLower().Contains(tb_KichCo_TimKiem.Text.ToLower()) || c.TenKc.ToLower().Contains(tb_KichCo_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstKichCo)
            {
                dtg_KichCo_Show.Rows.Add(x.Id, x.TenKc, x.MaKc);
            }
        }
        public void resetForm()
        {
            LoadData();
            _kc = null;
            tb_TenKichCo.Text = "";
            tb_maKichCo.Text = "";
        }

        private void btn_KichCo_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm kích cỡ này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maKichCo.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã kích cỡ ");
                }
                else if (_IKichCoSV.GetKichCo().Any(c => c.MaKc == tb_maKichCo.Text))
                {
                    MessageBox.Show("Mã kích cỡ này đã tồn tại");
                }
                else
                {
                    var kc = new KichCo()
                    {
                        Id = new Guid(),
                        TenKc = tb_TenKichCo.Text,
                        MaKc = tb_maKichCo.Text,
                    };
                    _IKichCoSV.add(kc);
                    MessageBox.Show("Thêm kích cỡ thành công");
                    resetForm();

                }
            }
        }

        private void btn_KichCo_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa kích cỡ này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_maKichCo.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã kích cỡ");
                }
                else if (_kc == null)
                {
                    MessageBox.Show("Vui lòng chọn kích cỡ");
                }
                else
                {
                    if (_kc.MaKc == tb_maKichCo.Text || (_kc.MaKc != tb_maKichCo.Text && _IKichCoSV.GetKichCo().FirstOrDefault(c => c.MaKc == tb_maKichCo.Text) == null))
                    {
                        _kc.TenKc = tb_TenKichCo.Text;
                        _kc.MaKc = tb_maKichCo.Text;
                        _IKichCoSV.update(_kc);
                        MessageBox.Show("Sửa kích cỡ thành công");
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Mã kích cỡ đã tồn tại");
                    }
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_KichCo_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa kích cỡ này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_kc == null)
                {
                    MessageBox.Show("Vui lòng chọn kích cỡ");
                }
                else
                {
                    _IKichCoSV.delete(_kc);
                    MessageBox.Show("Xóa kích cỡ thành công");
                    resetForm();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_ShowKichCo_Click(object sender, EventArgs e)
        {

        }

        private void btn_KichCo_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_KichCo_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_KichCo_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_KichCo_Show.Rows[e.RowIndex];
                _kc = _IKichCoSV.GetKichCo().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_TenKichCo.Text = r.Cells[1].Value.ToString();
                tb_maKichCo.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}
