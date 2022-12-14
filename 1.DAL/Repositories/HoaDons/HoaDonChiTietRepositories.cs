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
    public class HoaDonChiTietRepositories : IHoaDonChiTietRepositories
    {
        private QLBH_Context _context;
        private List<HoaDonChiTiet> _lstHDCT;
        public HoaDonChiTietRepositories()
        {
            _context = new QLBH_Context();
            _lstHDCT = new List<HoaDonChiTiet>();
        }

        public bool addHDCT(HoaDonChiTiet hoadonCT)
        {
            if (hoadonCT == null) return false;
            _context.hoaDonChiTiets.Add(hoadonCT);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHDCT(HoaDonChiTiet hoadonCT)
        {
            if (hoadonCT == null) return false;
            var temp = _context.hoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == hoadonCT.IdHoaDon);
            _context.hoaDonChiTiets.Remove(temp);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetHDCTFromDB()
        {
            _lstHDCT = _context.hoaDonChiTiets.ToList();
            return _lstHDCT;
        }

        public bool updateHDCT(HoaDonChiTiet hoadonCT)
        {
            if (hoadonCT == null) return false;
            var temp = _context.hoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == hoadonCT.IdHoaDon);
            temp.IdChiTietSp = hoadonCT.IdChiTietSp;
            temp.SoLuong = hoadonCT.SoLuong;
            temp.DonGia = hoadonCT.DonGia;
            _context.hoaDonChiTiets.Update(temp);
            _context.SaveChanges();
            return true;
        }
    }
}
