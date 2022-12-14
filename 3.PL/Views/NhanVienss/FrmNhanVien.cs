using _2.BUS.Services.ChucVus;
using _2.BUS.Services.CuaHangs;
using _2.BUS.Services.NhanViens;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.NhanVien
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _INhanVienServices;
        private IChucVuServices _IChucVuServices;
        private ICuaHangServices _ICuaHangServices;
        private Guid IdNhanvien;
        private _1.DAL.Entities.NhanVien _nv;
        private List<ViewNhanVien> _lstViewNhanVien;
        ViewNhanVien nhanVien;
        string avt = "";
        public FrmNhanVien()
        {
            InitializeComponent();
            _INhanVienServices = new NhanVienServices();
            _IChucVuServices = new ChucVuServices();
            _ICuaHangServices = new CuaHangServices();
            _lstViewNhanVien = new List<ViewNhanVien>();
            loadData();
            loadcbx();
        }
        public void loadData()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 13;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã NV";
            dtg_show.Columns[2].Name = "Họ và tên";
            dtg_show.Columns[3].Name = "Giới tính";
            dtg_show.Columns[4].Name = "Ngày sinh";
            dtg_show.Columns[5].Name = "CCCD";
            dtg_show.Columns[6].Name = "SDT";
            dtg_show.Columns[7].Name = "Email";
            dtg_show.Columns[8].Name = "Mật khẩu";
            dtg_show.Columns[9].Name = "Tên cửa hàng";
            dtg_show.Columns[10].Name = "Chức vụ";
            dtg_show.Columns[11].Name = "Địa chỉ";
            dtg_show.Columns[12].Name = "Trạng thái";
            _lstViewNhanVien = _INhanVienServices.GetViewChiTietSps();
            if (tb_timkiem.Text != "")
            {
                _lstViewNhanVien = _lstViewNhanVien.Where(p => p.MaNv.Contains(tb_timkiem.Text) || p.HoTenNv.Contains(tb_timkiem.Text)).ToList();
            }
            foreach (var item in _lstViewNhanVien)
            {
                dtg_show.Rows.Add(item.Id, item.MaNv, item.HoTenNv, item.GioiTinh, item.NgaySinh, item.CCCD, item.Sdt, item.Email, item.MatKhau, item.TenCuaHang, item.ChucVu, item.DiaChi,item.TrangThai == 1 ? "Làm việc" : "Nghỉ việc");
            }
        }
        public void reset()
        {
            loadData();
            tb_Ma.Text = "";
            tb_hovaten.Text = "";
            tb_sdt.Text = "";
            tb_cccd.Text = "";
            tb_diachi.Text = "";
            tb_email.Text = "";
            tb_matkhau.Text = "";
            rdb_danglam.Checked = true;
            rdb_dangnghi.Checked = false;
            cbx_chucvu.Text = "";
            cbx_cuahang.Text = "";
            cbx_gioitinh.Text = "";
        }
        public void loadcbx()
        {
            foreach (var item in _IChucVuServices.GetAll())
            {
                cbx_chucvu.Items.Add(item.TenCV);
            }
            foreach (var item in _ICuaHangServices.GetAll())
            {
                cbx_cuahang.Items.Add(item.TenCH);
            }
        }
        public bool checknhap()
        {
            if (tb_matkhau.Text == "" || tb_diachi.Text == "" || tb_hovaten.Text == "" ||  tb_Ma.Text == "" || tb_email.Text == "" || tb_cccd.Text == "" || tb_sdt.Text == "" || cbx_chucvu.Text == "" || cbx_cuahang.Text == "" || cbx_gioitinh.Text == "") return false;
            return true;
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            var ch = _ICuaHangServices.GetAll().FirstOrDefault(p => p.TenCH == cbx_cuahang.Text);
            var cv = _IChucVuServices.GetAll().FirstOrDefault(p => p.TenCV == cbx_chucvu.Text);
            var p = _INhanVienServices.GetNhanViens().FirstOrDefault(c => c.MaNv == tb_Ma.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(avt, Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(avt)), true);
            avt = Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(avt));
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Nhân viên không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ViewNhanVien nv = new ViewNhanVien()
                    {
                        IdCh = ch.Id,
                        IdCv = cv.Id,
                        MaNv = tb_Ma.Text,
                        HoTenNv = tb_hovaten.Text,
                        MatKhau = tb_matkhau.Text,
                        Anh = avt,
                        GioiTinh = cbx_gioitinh.Text,
                        NgaySinh = dtp_dob.Value,
                        CCCD = tb_cccd.Text,
                        Sdt = tb_sdt.Text,
                        Email = tb_email.Text,
                        DiaChi = tb_diachi.Text,
                        TrangThai = rdb_danglam.Checked ? 1 : 0,
                    };
                    _INhanVienServices.addSanPhamChiTiet(nv);
                    MessageBox.Show("Thêm thành công");
                    reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var ch = _ICuaHangServices.GetAll().FirstOrDefault(p => p.TenCH == cbx_cuahang.Text);
            var cv = _IChucVuServices.GetAll().FirstOrDefault(p => p.TenCV == cbx_chucvu.Text);
            var _product = _INhanVienServices.GetViewChiTietSps().FirstOrDefault(p => p.MaNv == tb_Ma.Text);
            if (_product == null)
            {
                MessageBox.Show("Không tìm thấy mã Nhân viên", "Cảnh báo");
            }
            else
            {
                if (checknhap() == false)
                {
                    MessageBox.Show("Không được để trống các trường", "Chú ý");
                }
                else
                {
                    OpenFileDialog op = new OpenFileDialog();
                    DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật Nhân viên không?", "Chú ý", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {

                        ViewNhanVien nv = new ViewNhanVien()
                        {
                            Id = IdNhanvien,
                            IdCh = ch.Id,
                            IdCv = cv.Id,
                            MaNv = tb_Ma.Text,
                            HoTenNv = tb_hovaten.Text,
                            Anh = avt,
                            MatKhau = tb_matkhau.Text,
                            GioiTinh = cbx_gioitinh.Text,
                            Email = tb_email.Text,
                            NgaySinh = dtp_dob.Value,
                            CCCD = tb_cccd.Text,
                            Sdt = tb_sdt.Text,
                            DiaChi = tb_diachi.Text,
                            TrangThai = rdb_danglam.Checked ? 1 : 0,
                        };
                        if (nv.Anh != avt)
                        {
                            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                            File.Copy(avt, Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(avt)), true);
                            avt = Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(avt));
                        }
                        _INhanVienServices.updateSanPhamChiTiet(nv);
                        MessageBox.Show("Sửa thành công");
                        reset();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (IdNhanvien == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn Nhân viên để xóa");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Nhân viên không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dlg = MessageBox.Show("Chú ý", "Bạn có muốn xóa sp ko", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        _INhanVienServices.deleteSanPhamChiTiet(IdNhanvien);
                        reset();
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                IdNhanvien = Guid.Parse(dtg_show.Rows[e.RowIndex].Cells[0].Value.ToString());
                _nv = _INhanVienServices.GetNhanViens().FirstOrDefault(p => p.Id == IdNhanvien);
                tb_Ma.Text = _nv.MaNv;
                tb_hovaten.Text = _nv.HoTenNv;
                cbx_cuahang.Text = _ICuaHangServices.GetAll().FirstOrDefault(p => p.Id == _nv.IdCh).TenCH;
                cbx_chucvu.Text = _IChucVuServices.GetAll().FirstOrDefault(p => p.Id == _nv.IdCv).TenCV;
                tb_cccd.Text = _nv.CCCD;
                tb_sdt.Text = _nv.Sdt;
                cbx_gioitinh.Text = _nv.GioiTinh;
                tb_matkhau.Text = _nv.MatKhau;
                tb_diachi.Text = _nv.DiaChi;
                tb_email.Text = _nv.Email;
                dtp_dob.Value = _nv.NgaySinh;
                avt = _nv.Anh;
                if (avt != null && File.Exists(avt))
                {
                    pictureBox1.Image = Image.FromFile(avt);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }
                if (_nv.TrangThai == 1)
                {
                    rdb_danglam.Checked = true;
                }
                else
                {
                    rdb_dangnghi.Checked = true;
                }
            }
        }

        private void tb_hovaten_TextChanged(object sender, EventArgs e)
        {
            tb_Ma.Text = Utilities.Utilities.GetMaTuSinh(tb_hovaten.Text) + (_INhanVienServices.GetNhanViens().Count + 1);
            tb_email.Text = tb_Ma.Text + "@fpt.edu.vn";
        }

        private void tb_cccd_Leave(object sender, EventArgs e)
        {
            Utilities.Utilities.checkChu(tb_cccd.Text);
        }

        private void tb_hovaten_Leave(object sender, EventArgs e)
        {
            //tb_hovaten.Text = Utilities.Utilities.VietHoaChuCaiDau(tb_hovaten.Text);
            Utilities.Utilities.CheckSo(tb_hovaten.Text);
        }

        private void tb_sdt_Leave(object sender, EventArgs e)
        {
            Utilities.Utilities.CheckSDT(tb_sdt.Text);
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            Utilities.Utilities.checkMail(tb_email.Text);
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                avt = op.FileName;
                pictureBox1.Image = Image.FromFile(op.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
