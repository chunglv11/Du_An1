 using _1.DAL.Entities;
using _2.BUS.ViewModels;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Repositories.HoaDons;
using _1.DAL.Repositories.SanPhams;

namespace _2.BUS.Services.HoaDons
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private IHoaDonChiTietRepositories _hoaDonChiTietReps;
        private IHoaDonRepositories _hoaDonReps;
        private IChiTietSpRepositories _chiTietSPReps;
        private ISanPhamRepositories _sanPhamReps;

        public HoaDonChiTietService()
        {
            _hoaDonReps = new HoaDonRepositories();
            _hoaDonChiTietReps = new HoaDonChiTietRepositories();
            _chiTietSPReps = new ChiTietSpRepositories();
            _sanPhamReps = new SanPhamRepositories();
        }
        public string Add(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDonChiTiet()
            {
                IdHoaDon = obj.IdHoaDon,
                IdChiTietSp = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
            };
            if (_hoaDonChiTietReps.addHDCT(HD)) return "Thêm thành công";
            return "không thành công";
        }

        public string Delete(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDonChiTiet()
            {
                IdHoaDon = obj.IdHoaDon,
                IdChiTietSp = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
            };
            if (_hoaDonChiTietReps.DeleteHDCT(HD)) return "Xóa thành công";
            return "không thành công";
        }

        public List<ViewHoaDonChiTiet> GetAll(Guid id)
        {
            List<ViewHoaDonChiTiet> lstHD = new List<ViewHoaDonChiTiet>();
            lstHD = (from a in _hoaDonChiTietReps.GetHDCTFromDB()
                     join b in _chiTietSPReps.GetChiTietSP() on a.IdChiTietSp equals b.Id
                     join c in _hoaDonReps.GetHoaDonFromDB() on a.IdHoaDon equals c.Id
                     join d in _sanPhamReps.GetAll() on b.IdSp equals d.Id
                     where a.IdHoaDon == id
                     select new ViewHoaDonChiTiet
                     {
                         IdChiTietSp = a.IdChiTietSp,
                         IdHoaDon = a.IdHoaDon,
                         SoLuong = a.SoLuong,
                         DonGia = a.DonGia,
                         TenSP = d.TenSp,
                     }).ToList();
            return lstHD;
        }

        public List<ViewHoaDonChiTiet> GetAll()
        {
            List<ViewHoaDonChiTiet> lstHD = new List<ViewHoaDonChiTiet>();
            lstHD = (from a in _hoaDonChiTietReps.GetHDCTFromDB()
                     join b in _chiTietSPReps.GetChiTietSP() on a.IdChiTietSp equals b.Id
                     join c in _hoaDonReps.GetHoaDonFromDB() on a.IdHoaDon equals c.Id
                     join d in _sanPhamReps.GetAll() on b.IdSp equals d.Id
                     select new ViewHoaDonChiTiet
                     {
                         IdChiTietSp = a.IdChiTietSp,
                         IdHoaDon = a.IdHoaDon,
                         SoLuong = a.SoLuong,
                         DonGia = a.DonGia,
                         TenSP = d.TenSp,
                     }).ToList();
            return lstHD;
        }

        public string Update(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDonChiTiet()
            {
                IdHoaDon = obj.IdHoaDon,
                IdChiTietSp = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
            };
            if (_hoaDonChiTietReps.updateHDCT(HD)) return "Sửa thành công";
            return "không thành công";
        }
    }
}
