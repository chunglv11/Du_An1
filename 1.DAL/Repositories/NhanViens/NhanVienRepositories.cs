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
        private List<Entities.NhanVien> _nhanVienslst;
        public NhanVienRepositories()
        {
            _context = new QLBH_Context();
            _nhanVienslst = new List<Entities.NhanVien>();
        }

        public bool addNhanVien(NhanVien nhanVien)
        {
            _context.nhanViens.Add(nhanVien);
            _context.SaveChanges();
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanVien)
        {
<<<<<<< HEAD
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
=======
            _context.nhanViens.Remove(nhanVien);
            _context.SaveChanges();
            return true;
>>>>>>> uuu
        }

        public NhanVien GetCheck(string Email)
        {
            NhanVien nv = _context.nhanViens.FirstOrDefault(p => p.Email == Email);
            return nv;
        }

        public NhanVien GetCheckPass(string Pass)
        {
            NhanVien nv = _context.nhanViens.FirstOrDefault(p => p.MatKhau == Pass);
            return nv;
        }

        public List<NhanVien> GetNhanVien()
        {
            _nhanVienslst = _context.nhanViens.ToList();
            return _nhanVienslst;
        }

        public NhanVien GetNhanVien(string ma, string matkhau)
        {
<<<<<<< HEAD
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
=======
            NhanVien nv = _context.nhanViens.FirstOrDefault(p => p.MaNv == ma && p.MatKhau == matkhau);
            return nv;
>>>>>>> uuu
        }

        public bool updateNhanVien(NhanVien nhanVien)
        {
            _context.nhanViens.Update(nhanVien);
            _context.SaveChanges();
            return true;
        }

        
    }
}
