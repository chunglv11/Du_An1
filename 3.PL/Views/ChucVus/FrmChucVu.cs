using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services.ChucVus;
using _1.DAL.Entities;

namespace _3.PL.Views.ChucVus
{
    public partial class FrmChucVu : Form
    {
        private IChucVuServices _ichucVuServices;
        ChucVu _chucVu;
        private Guid _id;
        public FrmChucVu()
        {
            InitializeComponent();
            _ichucVuServices = new ChucVuServices();
            _chucVu = new ChucVu();
            LoadData();
        }
        public void LoadData()
        {
            dgv_ShowCV.ColumnCount = 3;
            dgv_ShowCV.Rows.Clear();
            dgv_ShowCV.Columns[0].Name = "Id";
            dgv_ShowCV.Columns[0].Visible = false;
            dgv_ShowCV.Columns[1].Name = "Mã chức vụ";
            dgv_ShowCV.Columns[2].Name = "Tên chức vụ";
            foreach (var item in _ichucVuServices.GetAll())
            {
                dgv_ShowCV.Rows.Add(item.Id, item.MaCV, item.TenCV);
            }
        }
        private void LoadDataGridView(string input)
        {
            dgv_ShowCV.ColumnCount = 3;
            dgv_ShowCV.Columns[0].Name = " ID";
            dgv_ShowCV.Columns[1].Name = "Mã chức vụ";
            dgv_ShowCV.Columns[2].Name = "Tên chức vụ";
            dgv_ShowCV.Rows.Clear();
            foreach (var x in _ichucVuServices.GetAll(input))
            {
                dgv_ShowCV.Rows.Add(x.Id, x.MaCV, x.TenCV);
            }
        }
        public bool checknhap()
        {
            if (tb_MaCv.Text == "" || tb_TenCv.Text == "") return false;
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var p = _ichucVuServices.GetAll().FirstOrDefault(x => x.MaCV == tb_MaCv.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Chức vụ đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Chức vụ không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var cv = new ChucVu()
                    {
                        Id = new Guid(),
                        MaCV = tb_MaCv.Text,
                        TenCV = tb_TenCv.Text,
                    };
                    _ichucVuServices.Add(cv);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_chucVu == null)
            {
                MessageBox.Show("Không tìm thấy mã Chức vụ", "Cảnh báo");
            }
            else if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn Sửa Chức vụ không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (_chucVu.MaCV == tb_MaCv.Text || _chucVu.MaCV != tb_MaCv.Text && _ichucVuServices.GetAll().FirstOrDefault(c => c.MaCV == tb_MaCv.Text) == null)
                    {
                        _chucVu.MaCV = tb_MaCv.Text;
                        _chucVu.MaCV = tb_TenCv.Text;
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Chức vụ này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_chucVu == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _ichucVuServices.Delete(_chucVu);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }

        private void dgv_ShowCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                _id = Guid.Parse(dgv_ShowCV.Rows[rowindex].Cells[0].Value.ToString());
                _chucVu = _ichucVuServices.GetAll().FirstOrDefault(c => c.Id == _id);
                tb_MaCv.Text = _chucVu.MaCV;
                tb_TenCv.Text = _chucVu.TenCV;
            }
        }
        public void Reset()
        {
            LoadData();
            _chucVu = null;
            txt_TimKiem.Text = "";
            tb_MaCv.Text = "";
            tb_TenCv.Text = "";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView(txt_TimKiem.Text);
        }

        private void tb_MaCv_TextChanged(object sender, EventArgs e)
        {
            tb_MaCv.Text = "CV" + Utilities.Utilities.GetMaTuSinh(tb_TenCv.Text) + (_ichucVuServices.GetAll().Count + 1);
        }

        private void tb_TenCv_TextChanged(object sender, EventArgs e)
        {
            tb_TenCv.Text = Utilities.Utilities.VietHoaChuCaiDau(tb_TenCv.Text);
        }
    }
}
