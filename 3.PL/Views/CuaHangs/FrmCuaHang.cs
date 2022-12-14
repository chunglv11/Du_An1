using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services.CuaHangs;
using _1.DAL.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace _3.PL.Views.CuaHangs
{
    public partial class FrmCuaHang : Form
    {
        private ICuaHangServices _icuaHangServices;
        private CuaHang _CH;
        private Guid _id;

        public FrmCuaHang()
        {
            InitializeComponent();
            _icuaHangServices = new CuaHangServices();
            _CH = new CuaHang();
            LoadData();
        }
        public void LoadData()
        {
            dgv_ShowCuaHang.ColumnCount = 6;
            dgv_ShowCuaHang.Rows.Clear();
            dgv_ShowCuaHang.Columns[0].Name = "Id";
            dgv_ShowCuaHang.Columns[0].Visible = false;
            dgv_ShowCuaHang.Columns[1].Name = "Mã cửa hàng";
            dgv_ShowCuaHang.Columns[2].Name = "Tên cửa hàng";
            dgv_ShowCuaHang.Columns[3].Name = "Địa chỉ";
            dgv_ShowCuaHang.Columns[4].Name = "Thành phố";
            dgv_ShowCuaHang.Columns[5].Name = "Quốc gia";
            foreach (var item in _icuaHangServices.GetAll())
            {
                dgv_ShowCuaHang.Rows.Add(item.Id, item.MaCH, item.TenCH, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }
        public void LoadDataGridView(string input)
        {
            dgv_ShowCuaHang.ColumnCount = 6;
            dgv_ShowCuaHang.Rows.Clear();
            dgv_ShowCuaHang.Columns[0].Name = "Id";
            dgv_ShowCuaHang.Columns[0].Visible = false;
            dgv_ShowCuaHang.Columns[1].Name = "Mã cửa hàng";
            dgv_ShowCuaHang.Columns[2].Name = "Tên cửa hàng";
            dgv_ShowCuaHang.Columns[3].Name = "Địa chỉ";
            dgv_ShowCuaHang.Columns[4].Name = "Thành phố";
            dgv_ShowCuaHang.Columns[5].Name = "Quốc gia";
            foreach (var item in _icuaHangServices.GetAll(input))
            {
                dgv_ShowCuaHang.Rows.Add(item.Id, item.MaCH, item.TenCH, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }
        public void Reset()
        {
            LoadData();
            _CH = null;
            tb_TimKiem.Text = "";
            tb_Ma.Text = "";
            tb_Ten.Text = "";
            tb_DiaChi.Text = "";
            tb_ThanhPho.Text = "";
            tb_QuocGia.Text = "";
        }
        public bool checknhap()
        {
            if (tb_Ma.Text == "" || tb_DiaChi.Text == "" || tb_Ten.Text == "" || tb_ThanhPho.Text == "" || tb_QuocGia.Text == "") return false;
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var p = _icuaHangServices.GetAll().FirstOrDefault(x => x.MaCH == tb_Ma.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Cửa hàng đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Cửa hàng không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var cv = new CuaHang()
                    {
                        Id = new Guid(),
                        MaCH = tb_Ma.Text,
                        TenCH = tb_Ten.Text,
                        DiaChi = tb_DiaChi.Text,
                        ThanhPho = tb_ThanhPho.Text,
                        QuocGia = tb_QuocGia.Text,
                    };
                    _icuaHangServices.Add(cv);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_CH == null)
            {
                MessageBox.Show("Không tìm thấy mã Cửa hàng", "Cảnh báo");
            }
            else if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn Sửa Cửa hàng không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (_CH.MaCH == tb_TimKiem.Text || _CH.MaCH != tb_TimKiem.Text && _icuaHangServices.GetAll().FirstOrDefault(c => c.MaCH == tb_TimKiem.Text) == null)
                    {
                        _CH.MaCH = tb_TimKiem.Text;
                        _CH.TenCH = tb_TimKiem.Text;
                        _CH.DiaChi = tb_TimKiem.Text;
                        _CH.ThanhPho = tb_TimKiem.Text;
                        _CH.QuocGia = tb_TimKiem.Text;
                        MessageBox.Show("Sửa thành công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show(" Sửa không thành công");
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Cửa hàng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_CH == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _icuaHangServices.Delete(_CH);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }

        private void dgv_ShowCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                _id = Guid.Parse(dgv_ShowCuaHang.Rows[rowindex].Cells[0].Value.ToString());
                _CH = _icuaHangServices.GetAll().FirstOrDefault(c => c.Id == _id);
                tb_Ma.Text = _CH.MaCH;
                tb_Ten.Text = _CH.TenCH;
                tb_DiaChi.Text = _CH.DiaChi;
                tb_ThanhPho.Text = _CH.ThanhPho;
                tb_QuocGia.Text = _CH.QuocGia;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Utilities.Utilities.ResetControlValues(this);
            tb_QuocGia.Text = "Việt Nam";
        }

        private void tb_Ten_Leave(object sender, EventArgs e)
        {
            tb_Ten.Text = Utilities.Utilities.VietHoaChuCaiDau(tb_Ten.Text);
        }

        private void tb_DiaChi_Leave(object sender, EventArgs e)
        {
            tb_DiaChi.Text = Utilities.Utilities.VietHoaChuCaiDau(tb_DiaChi.Text);
        }

        private void tb_ThanhPho_Leave(object sender, EventArgs e)
        {
            tb_ThanhPho.Text = Utilities.Utilities.VietHoaChuCaiDau(tb_ThanhPho.Text);
        }

        private void tb_QuocGia_Leave(object sender, EventArgs e)
        {
            tb_QuocGia.Text = Utilities.Utilities.VietHoaChuCaiDau(tb_QuocGia.Text);
        }


        private void tb_Ten_TextChanged(object sender, EventArgs e)
        {
            tb_Ma.Text = "CH" + Utilities.Utilities.GetMaTuSinh(tb_Ten.Text) + (_icuaHangServices.GetAll().Count + 1);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView(tb_TimKiem.Text);
        }
    }
}
