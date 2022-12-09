using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3.PL.Views.BanHang;
using _3.PL.Views.CuaHangs;
using _3.PL.Views.ChucVus;
using _3.PL.Views.DangNhap;
using _3.PL.Views.HoaDon;
using _3.PL.Views.KhachHang;
using _3.PL.Views.NhanViens;
using _3.PL.Views.SanPham;

namespace _3.PL.Views
{
    public partial class _Main : Form
    {
        public _Main()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private void ChangeForm(Form childForm)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Desk.Controls.Add(childForm);
            ptb_Desktop.Hide();
            childForm.Show();
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmBanHang());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmHoaDon());
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmChiTietSP());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmNhanVien());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmKhachHang());
        }
    }
}
