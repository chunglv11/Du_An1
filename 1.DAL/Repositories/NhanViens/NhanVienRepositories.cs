using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;
using _1.DAL.Ultilities.Password;

namespace _1.DAL.Repositories.NhanViens
{
    public class NhanVienRepositories : INhanVienRepositories
    {
        private QLBH_Context _context;
        private List<NhanVien> _lstNhanVien;
        public NhanVienRepositories()
        {
            _context = new QLBH_Context();
            _lstNhanVien = new List<NhanVien>();
        }
        public bool AddNvFromDb(NhanVien obj)
        {
            try
            {
                obj.MatKhau = CreatePassword.CreateRandomPassword(6);
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteNvFromDb(NhanVien obj)
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

        public List<NhanVien> GetAllNvFromDb()
        {
            _lstNhanVien = _context.nhanViens.ToList();
            return _lstNhanVien;
        }

        public NhanVien GetByNameEmail(string email)
        {
            if (email == String.Empty)
            {
                return null;
            }
            else
            {
                return _context.nhanViens.FirstOrDefault(c => c.Email == email);
            }
        }

        public bool UpdateNvFromDb(NhanVien obj)
        {
            try
            {
                NhanVien nv = _context.nhanViens.Find(obj.Id);
                nv.IdCh = obj.IdCh;
                nv.IdCv = obj.IdCv;
                nv.MaNv = obj.MaNv;
                nv.HoTenNv = obj.HoTenNv;
                nv.GioiTinh = obj.GioiTinh;
                nv.NgaySinh = obj.NgaySinh;
                nv.DiaChi = obj.DiaChi;
                nv.CCCD = obj.CCCD;
                nv.Sdt = obj.Sdt;
                nv.Email = obj.Email;
                nv.MatKhau = obj.MatKhau;
                nv.Anh = obj.Anh;
                nv.TrangThai = obj.TrangThai;
                _context.Update(nv);
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
