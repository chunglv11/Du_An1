
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Repositories.HoaDons
{
    public class HoaDonRepositories : IHoaDonRepositories
    {
        private QLBH_Context _context;
        private List<HoaDon> _lstHoaDon;
        public HoaDonRepositories()
        {
            _context = new QLBH_Context();
            _lstHoaDon = new List<HoaDon>();
            GetHoaDonFromDB();
        }

        public bool addHoaDon(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            hoadon.Id = Guid.NewGuid();
            _context.hoaDons.Add(hoadon);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            var temp = _context.hoaDons.FirstOrDefault(c => c.Id == hoadon.Id);
            _context.hoaDons.Remove(temp);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetHoaDonFromDB()
        {
            _lstHoaDon = _context.hoaDons.ToList();
            return _lstHoaDon;
        }

        public bool updateHoaDon(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            var temp = _context.hoaDons.FirstOrDefault(c => c.Id == hoadon.Id);
            temp.IdKh = hoadon.IdKh;
            temp.IdNv = hoadon.IdNv;
            temp.MaHD = hoadon.MaHD;
            temp.NgayTao = hoadon.NgayTao;
            temp.NgayThanhToan = hoadon.NgayThanhToan;
            temp.NgayShip = hoadon.NgayShip;
            temp.TenNguoiShip = hoadon.TenNguoiShip;
            temp.NgayNhan = hoadon.NgayNhan;
            temp.TenNguoiNhan = hoadon.TenNguoiNhan;
            temp.DiaChi = hoadon.DiaChi;
            temp.Sdt = hoadon.Sdt;
            temp.TongTien = hoadon.TongTien;
            temp.TinhTrang = hoadon.TinhTrang;
            _context.hoaDons.Update(temp);
            _context.SaveChanges();
            return true;
        }
    }
}
