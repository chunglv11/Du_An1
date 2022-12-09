using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using _2.BUS.Services.NhanViens;
using _2.BUS.Services.CuaHangs;
using _2.BUS.Services.ChucVus;
using _2.BUS.ViewModels;
using _1.DAL.Entities;

namespace _3.PL.Views.NhanViens
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _inhanVienServices;
        private ICuaHangServices _icuaHangServices;
        private IChucVuServices _ichucVuServices;
        private List<NhanVienVm> _lstNhanVien;
        private Guid _id;
        private string _linkAnh = "";
        public FrmNhanVien()
        {
            InitializeComponent();
            _inhanVienServices = new NhanVienServices();
            _icuaHangServices = new CuaHangServices();
            _ichucVuServices = new ChucVuServices();
            _lstNhanVien = new List<NhanVienVm>();
            LoadData();
            
        }

        public void LoadData()
        {
            dgv_ShowNV.ColumnCount = 13;
            dgv_ShowNV.Columns[0].Name = "Id";
            dgv_ShowNV.Columns[0].Visible = false;
            dgv_ShowNV.Columns[1].Name = "Mã cửa hàng";
            dgv_ShowNV.Columns[2].Name = "Tên chức vụ";
            dgv_ShowNV.Columns[3].Name = "Mã nhân viên";
            dgv_ShowNV.Columns[4].Name = "Họ tên";
            dgv_ShowNV.Columns[5].Name = "Giới tính";
            dgv_ShowNV.Columns[6].Name = "Ngày sinh";
            dgv_ShowNV.Columns[7].Name = "Địa chỉ";
            dgv_ShowNV.Columns[8].Name = "CCCD";
            dgv_ShowNV.Columns[9].Name = "Số điện thoại";
            dgv_ShowNV.Columns[10].Name = "Email";
            dgv_ShowNV.Columns[11].Name = "Ảnh";
            dgv_ShowNV.Columns[12].Name = "Trạng thái";
            dgv_ShowNV.Rows.Clear();
            foreach (var x in _inhanVienServices.ShowAllNhanVien())
            {
                dgv_ShowNV.Rows.Add(x.Id, x.MaCH, x.TenCV, x.MaNv, x.HoTenNv, x.GioiTinh == 0 ? "Nam" : x.GioiTinh == 1 ? "Nữ" : "Không xác định", x.NgaySinh, x.DiaChi, x.CCCD, x.Sdt, x.Email, x.Anh, x.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img.HeaderText = "Ảnh Nhân Viên";
            //img.Name = "img_nv";
            //img.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ShowNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Image img1 = Image.FromFile(Convert.ToString(dgv_ShowNV.Rows[e.RowIndex].Cells[11].Value.ToString()));
            ptb_Avata.Image = img1;
        }
        public void loadimg(ref string imgname)
        {
            OpenFileDialog fileimgname = new OpenFileDialog();
            if (fileimgname.ShowDialog() == DialogResult.OK)
            {
                imgname = fileimgname.FileName;
                
            }

        }
        public void LoadAnh()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Ảnh Nhân Viên";
            img.Name = "img_nv";
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_ShowNV.Columns.Add(img);
            dgv_ShowNV.Rows.Clear();
            for (int i = 0; i < dgv_ShowNV.RowCount; i++)
            {
                Image img2 = Image.FromFile(Convert.ToString(dgv_ShowNV.Rows[i].Cells[11].Value));

                dgv_ShowNV.Rows[i].Cells["img_nv"].Value = img2;

            }

        }
        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            loadimg(ref _linkAnh);
            ptb_Avata.Image = new Bitmap(_linkAnh);
        }
    }
}
