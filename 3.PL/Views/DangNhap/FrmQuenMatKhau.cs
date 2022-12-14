using _2.BUS.Services.NhanViens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.DangNhap
{
    public partial class FrmQuenMatKhau : Form
    {
        INhanVienServices _INhanVienServices;
        public _1.DAL.Entities.NhanVien _nv;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {
            lb_loichao.Text = "Xin chao:" + _nv.HoTenNv; 
            tb_ma.Text = _nv.MaNv;
            tb_ma.Enabled = false;
            tb_email.Text = _nv.Email;
            tb_email.Enabled = false;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var a = _INhanVienServices.GetNhanViens().FirstOrDefault(c => c.Email == tb_email.Text).Id;
            var d = _INhanVienServices.GetNhanViens().FirstOrDefault(p => p.Id == a);
            d.MatKhau = tb_pass.Text;
            _INhanVienServices.updateSanPhamChiTiets(d);
            MessageBox.Show("Thay Đổi Mật Khẩu Thành Công , Bạn Sẽ Được Đưa Trở Lại Trang Chủ");
            this.Hide();
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
        }
    }
}
