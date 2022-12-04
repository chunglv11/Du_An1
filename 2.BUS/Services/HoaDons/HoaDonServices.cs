using _1.DAL.Entities;
using _1.DAL.Repositories.HoaDons;
using _1.DAL.Repositories.KhachHangs;
using _1.DAL.Repositories.NhanViens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.HoaDons
{
    public class HoaDonServices : IHoaDonServices
    {
        private IHoaDonRepositories _ihoaDonRepositories;
        private IKhachHangRepositories _ikhachHangRepositories;
        private INhanVienRepositories _inhanVienRepositories;
        private List<HoaDon> _lstHoaDon;
        public HoaDonServices()
        {
            _ihoaDonRepositories = new HoaDonRepositories();
            _ikhachHangRepositories = new KhachHangRepositories();
            _inhanVienRepositories = new NhanVienRepositories();
            _lstHoaDon = new List<HoaDon>();
        }
        public bool AddHd(HoaDon obj)
        {
            if(obj == null)
                return false;
            _ihoaDonRepositories.AddHdFromDb(obj);
            return true;
        }

        public bool DeleteHd(HoaDon obj)
        {
            if (obj == null)
                return false;
            _ihoaDonRepositories.DeleteHdFromDb(obj);
            return true;
        }

        public List<HoaDon> GetHoaDon()
        {
            _lstHoaDon = (from a in _ihoaDonRepositories.GetHoaDonFromDb()
                        //  join b in _ikhachHangRepositories.GetKhachHangKhFromDb() on a.IdKh equals b.Id
                          join c in _inhanVienRepositories.GetAllNvFromDb() on a.IdNv equals c.Id
                          select new HoaDon
                          {
                              MaHD = a.MaHD,
                              IdKh = a.IdKh,
                              IdNv = a.IdNv,
                              NgayTao = a.NgayTao,
                              NgayThanhToan = a.NgayThanhToan,
                              NgayShip = a.NgayShip,
                              TenNguoiShip = a.TenNguoiShip,
                              TenNguoiNhan = a.TenNguoiNhan,
                              NgayNhan = a.NgayNhan,
                              Sdt  = a.Sdt,
                              DiaChi = a.DiaChi,
                              TongTien = a.TongTien,
                              TinhTrang = a.TinhTrang,
                             
                          }
                          ).ToList();
            return _lstHoaDon;
        }

        public bool UpdateHd(HoaDon obj)
        {
            if (obj == null)
                return false;
            _ihoaDonRepositories.UpdateHdFromDb(obj);
            return true;
        }
    }
}
