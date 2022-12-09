using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Repositories.KhachHangs
{
    public class KhachHangRepositories : IKhachHangRepositories
    {
        private QLBH_Context _context;
        private List<KhachHang> _lstKhachHang;
        public KhachHangRepositories()
        {
            _context = new QLBH_Context();
            _lstKhachHang = new List<KhachHang>();
            GetKhachHangKhFromDb();
        }

        public bool AddKhFromDb(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.khachHangs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteKhFromDb(KhachHang obj)
        {
            if (obj == null) return false;
            var temp = _context.khachHangs.FirstOrDefault(c => c.Id == obj.Id);
            _context.khachHangs.Remove(temp);
            _context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetKhachHangKhFromDb()
        {
            _lstKhachHang = _context.khachHangs.ToList();
            return _lstKhachHang;
        }

        public bool UpdateKhFromDb(KhachHang obj)
        {
            if (obj == null) return false;
            var temp = _context.khachHangs.FirstOrDefault(c => c.Id == obj.Id);
            temp.MaKH = obj.MaKH;
            temp.HoTenKH = obj.HoTenKH;
            temp.Sdt = obj.Sdt;
            temp.DiaChi = obj.DiaChi;
            _context.khachHangs.Update(temp);
            _context.SaveChanges();
            return true;
        }
    }
}
