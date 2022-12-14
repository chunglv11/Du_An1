using _1.DAL.Repositories.HoaDons;
using _2.BUS.Services.HoaDons;
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

namespace _3.PL.Views.HoaDon
{
    public partial class FrmHoaDon : Form
    {
        private IHoaDonChiTietService _hoaDonChiTietServices;
        private IHoaDonServices _cHoaDonServices;
        private IChiTietSpServices _chiTietSPServices;
        private Guid _ID;
        public FrmHoaDon()
        {
            InitializeComponent();
            _chiTietSPServices = new ChiTietSpServices();
            _hoaDonChiTietServices = new HoaDonChiTietService();
            _cHoaDonServices = new HoaDonServices();
            loadHD();
        }
        public void loadHD()
        {
            dgrid_hoadon.Rows.Clear();
            dgrid_hoadon.Rows.Clear();
            foreach (var item in _cHoaDonServices.GetAll())
            {
                dgrid_hoadon.Rows.Add(item.Id, item.MaHD, item.NgayTao,item.NgayThanhToan ,item.NgayShip,item.NgayNhan ,item.TenNguoiNhan, item.DiaChi, item.Sdt, item.TongTien, item.TinhTrang == 1 ? "Đã thanh toán" : "Chờ thanh toán");
            }
        }
        public void loadHDCT(Guid id)
        {
            _ID = id;
            dgrid_hdct.Rows.Clear();
            foreach (var item in _hoaDonChiTietServices.GetAll(id))
            {
                dgrid_hdct.Rows.Add(item.IdChiTietSp,item.IdHoaDon ,item.TenSP, item.SoLuong, item.DonGia);
            }
        }


        private void btn_HD_TimKiem_Click(object sender, EventArgs e)
        {
            dgrid_hoadon.Rows.Clear();
            dgrid_hoadon.Rows.Clear();
            var items = _cHoaDonServices.GetAll().Where(x => x.MaHD == Text);
            if (items.Any())
            {
                foreach (var item in _cHoaDonServices.GetAll(txt_TK.Text))
                {
                    dgrid_hoadon.Rows.Add(item.Id, item.MaHD, item.NgayTao, item.NgayThanhToan, item.NgayShip, item.NgayNhan, item.TenNguoiNhan, item.DiaChi, item.Sdt, item.TongTien, item.TinhTrang == 1 ? "Đã thanh toán" : "Chờ thanh toán");
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào có Mã hóa đơn tương ứng");
            }
        }

        private void dgrid_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _ID = Guid.Parse(dgrid_hoadon.Rows[e.RowIndex].Cells[0].Value.ToString());
                loadHDCT(_ID);
            }
        }
    }
}
