using _1.DAL.Entities;
using _1.DAL.Repositories.NhanViens;
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
    public partial class FrmLogin : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmLogin()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }
        public void saveInfor()
        {
            if (cb_GhiNho.Checked == true)
            {
                Properties.Settings1.Default.User = tb_taikhoan.Text;
                Properties.Settings1.Default.Pass = tb_MatKhau.Text;
                Properties.Settings1.Default.TKdaLogin = tb_taikhoan.Text;
                Properties.Settings1.Default.MKdaLogin = tb_MatKhau.Text;
                Properties.Settings1.Default.Save();

            }
            else
            {
                Properties.Settings1.Default.User = "";
                Properties.Settings1.Default.Pass = "";
                Properties.Settings1.Default.TKdaLogin = tb_taikhoan.Text;
                Properties.Settings1.Default.MKdaLogin = tb_MatKhau.Text;
                Properties.Settings1.Default.Save();
            }
        }
        private void btn_DangNap_Click(object sender, EventArgs e)
        {
            var login = _nhanVienServices.GetViewChiTietSps().Where(p => p.MaNv == tb_taikhoan.Text && p.MatKhau == tb_MatKhau.Text).FirstOrDefault();
            if (login != null)
            {
                saveInfor();
                this.Hide();
               _Main frmBanHang = new _Main();
                frmBanHang.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void lb_QuenMk_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmtk = new FrmTimKiem();
            frmtk.ShowDialog();
        }

        private void cb_GhiNho_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_taikhoan.Text != "" && tb_MatKhau.Text != "")
            {
                if (cb_GhiNho.Checked == true)
                {
                    string use = tb_taikhoan.Text;
                    string pass = tb_MatKhau.Text;
                    Properties.Settings1.Default.User = use;
                    Properties.Settings1.Default.Pass = pass;
                    Properties.Settings1.Default.Save();
                }
                else
                {
                    Properties.Settings1.Default.Reset();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tb_taikhoan.Text = Properties.Settings1.Default.User;
            tb_MatKhau.Text = Properties.Settings1.Default.Pass;
            if (Properties.Settings1.Default.User != "")
            {
                cb_GhiNho.Checked = true;
            }
        }
    }
}
