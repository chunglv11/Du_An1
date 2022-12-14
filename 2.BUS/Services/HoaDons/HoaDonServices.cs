using _1.DAL.Entities;
using _1.DAL.Repositories.HoaDons;
using _1.DAL.Repositories.KhachHangs;
using _1.DAL.Repositories.NhanViens;
using _2.BUS.ViewModels;
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

        public string Add(ViewHoaDon obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDon()
            {
                Id = obj.Id,
                IdKh = obj.IdKh,
                IdNv = obj.IdNv,
                MaHD = obj.MaHD,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayShip = obj.NgayShip,
                NgayNhan = obj.NgayNhan,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                TongTien = obj.TongTien,
                TinhTrang = obj.TinhTrang,

            };
            if (_ihoaDonRepositories.addHoaDon(HD)) return "Thêm thành công";
            return "không thành công";
        }

        public string Delete(ViewHoaDon obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDon()
            {
                Id = obj.Id,
                IdKh = obj.IdKh,
                IdNv = obj.IdNv,
                MaHD = obj.MaHD,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayShip = obj.NgayShip,
                NgayNhan = obj.NgayNhan,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                TongTien = obj.TongTien,
                TinhTrang = obj.TinhTrang,
            };
            if (_ihoaDonRepositories.DeleteHoaDon(HD)) return "Xóa thành công";
            return "không thành công";
        }

        public List<ViewHoaDon> GetAll(string input)
        {
            List<ViewHoaDon> lstHD = new List<ViewHoaDon>();
            lstHD = (from a in _ihoaDonRepositories.GetHoaDonFromDB()
                     join b in _ikhachHangRepositories.GetKhachHangKhFromDb() on a.IdKh equals b.Id
                     join c in _inhanVienRepositories.GetNhanVien() on a.IdNv equals c.Id
        
                     where a.MaHD == input
                     select new ViewHoaDon
                     {
                         Id = a.Id,
                         IdKh = a.IdKh,
                         IdNv = a.IdNv,
                         MaHD = a.MaHD,
                         NgayTao = a.NgayTao,
                         NgayThanhToan =a.NgayThanhToan,
                         NgayShip = a.NgayShip,
                         NgayNhan = a.NgayNhan,
                         TenNguoiNhan = a.TenNguoiNhan,
                         DiaChi = a.DiaChi,
                         Sdt = b.Sdt,
                         TongTien = a.TongTien,
                         TinhTrang = a.TinhTrang,
                         TenKH = b.HoTenKH,
                         TenNV = c.HoTenNv,
                     }).ToList();
            return lstHD;
        }

        public List<ViewHoaDon> GetAll()
        {
<<<<<<< HEAD
            _lstHoaDon = (from a in _ihoaDonRepositories.GetHoaDonFromDb()
                        //  join b in _ikhachHangRepositories.GetKhachHangKhFromDb() on a.IdKh equals b.Id
                          join c in _inhanVienRepositories.GetAllNvFromDb() on a.IdNv equals c.Id
                          select new HoaDon()
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
=======
            List<ViewHoaDon> lstHD = new List<ViewHoaDon>();
            lstHD = (from a in _ihoaDonRepositories.GetHoaDonFromDB()
                     join b in _ikhachHangRepositories.GetKhachHangKhFromDb() on a.IdKh equals b.Id
                     join c in _inhanVienRepositories.GetNhanVien() on a.IdNv equals c.Id
                  
                     select new ViewHoaDon
                     {
                         Id = a.Id,
                         IdKh = a.IdKh,
                         IdNv = a.IdNv,
                         MaHD = a.MaHD,
                         NgayTao = a.NgayTao,
                         NgayThanhToan = a.NgayThanhToan,
                         NgayShip = a.NgayShip,
                         NgayNhan = a.NgayNhan,
                         TenNguoiNhan = a.TenNguoiNhan,
                         DiaChi = a.DiaChi,
                         Sdt = b.Sdt,
                         TongTien = a.TongTien,
                         TinhTrang = a.TinhTrang,
                         TenKH = b.HoTenKH,
                         TenNV = c.HoTenNv,
                     }).ToList();
            return lstHD;
>>>>>>> uuu
        }

        public string Update(ViewHoaDon obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDon()
            {
                Id = obj.Id,
                IdKh = obj.IdKh,
                IdNv = obj.IdNv,
                MaHD = obj.MaHD,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayShip = obj.NgayShip,
                NgayNhan = obj.NgayNhan,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                TongTien = obj.TongTien,
                TinhTrang = obj.TinhTrang,
            };
            if (_ihoaDonRepositories.updateHoaDon(HD)) return "Sửa thành công";
            return "không thành công";
        }
    }
}
