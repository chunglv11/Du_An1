using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;

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
        }

        public bool AddKhFromDb(KhachHang obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteKhFromDb(KhachHang obj)
        {
            try
            {
                _context.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<KhachHang> GetKhachHangKhFromDb()
        {
            _lstKhachHang = _context.khachHangs.ToList();
            return _lstKhachHang;
        }

        public bool UpdateKhFromDb(KhachHang obj)
        {
            try
            {
                KhachHang kh = _context.khachHangs.Find(obj.Id);
                kh.MaKH = obj.MaKH;
                kh.HoTenKH = obj.HoTenKH;
                kh.DiaChi = obj.DiaChi;
                kh.Sdt = obj.Sdt;
                _context.Update(kh);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
