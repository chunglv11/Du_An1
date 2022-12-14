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
    public partial class FrmDoiMK : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmDoiMK()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }

        private void btn_DoiMK_XacNhan_Click(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.MaNv == Properties.Settings1.Default.TKdaLogin).Id;
            var id = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.Id == idRole);
            if (tb_mkc.Text != id.MatKhau)
            {
                MessageBox.Show("Sai mật khẩu vui lòng nhập lại");
            }
            else if (tb_mkm.Text != tb_nlmk.Text)
            {
                MessageBox.Show("Sai mật khẩu mới vui lòng nhập lại");
            }
            else
            {
                var p = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.Id == idRole);
                p.MatKhau = tb_mkm.Text;
                _nhanVienServices.updateSanPhamChiTiets(p);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }
    }
}
