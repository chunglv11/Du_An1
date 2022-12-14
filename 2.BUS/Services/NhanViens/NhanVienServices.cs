using _1.DAL.Entities;
<<<<<<< HEAD
using _2.BUS.ViewModels;
using _1.DAL.Repositories.NhanViens;
using _1.DAL.Repositories.CuaHangs;
using _1.DAL.Repositories.ChucVus;
=======
using _1.DAL.Repositories.ChucVus;
using _1.DAL.Repositories.CuaHangs;
using _1.DAL.Repositories.NhanViens;
using _2.BUS.ViewModels;
>>>>>>> uuu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.NhanViens
{
    public class NhanVienServices : INhanVienServices
    {
<<<<<<< HEAD
        private INhanVienRepositories _inhanVienRepositories;
        private IChucVuRepositories _ichucVuRepositories;
        private ICuaHangRepositories _icuaHangRepositories;
        private List<NhanVien> _lstNhanVien;
        public NhanVienServices()
        {
            _inhanVienRepositories = new NhanVienRepositories();
            _ichucVuRepositories = new ChucVuRepositories();
            _icuaHangRepositories = new CuaHangRepositories();
            _lstNhanVien = new List<NhanVien>();
        }
        public bool AddNv(NhanVien obj)
        {
            // Đầu tiên phải tìm xem user này có tồn tại hay không
            var exist = _inhanVienRepositories.GetByNameEmail(obj.Email);
            if (exist != null)
            {
                return false;
            }
            return _inhanVienRepositories.AddNvFromDb(obj);
=======
        private INhanVienRepositories _INhanVienReps;
        private ICuaHangRepositories _ICuaHangReps;
        private IChucVuRepositories _IChucVuReps;
        private List<ViewNhanVien> _viewNhanVienslst;
        private List<NhanVien> _lstNhanVien;
        public NhanVienServices()
        {
            _IChucVuReps = new ChucVuRepositories();
            _ICuaHangReps = new CuaHangRepositories();
            _INhanVienReps = new NhanVienRepositories();
            _viewNhanVienslst = new List<ViewNhanVien>();
        }
        public bool addSanPhamChiTiet(ViewNhanVien nhanVien)
        {
            NhanVien nv = new NhanVien()
            {
                Id = nhanVien.Id,
                MaNv = nhanVien.MaNv,
                HoTenNv = nhanVien.HoTenNv,
                Anh = nhanVien.Anh,
                GioiTinh = nhanVien.GioiTinh,
                NgaySinh = nhanVien.NgaySinh,
                CCCD = nhanVien.CCCD,
                Sdt = nhanVien.Sdt,
                MatKhau = nhanVien.MatKhau,
                Email = nhanVien.Email,
                IdCh = nhanVien.IdCh,
                IdCv = nhanVien.IdCv,
                DiaChi = nhanVien.DiaChi,
                TrangThai = nhanVien.TrangThai
            };
            _INhanVienReps.addNhanVien(nv);
            return true;
        }

        public bool deleteSanPhamChiTiet(Guid idnv)
        {
            var x = _INhanVienReps.GetNhanVien().FirstOrDefault(p => p.Id == idnv);
            _INhanVienReps.deleteNhanVien(x);
            return true;
        }

        public List<NhanVien> GetNhanViens()
        {
            _lstNhanVien = _INhanVienReps.GetNhanVien().ToList();
            return _lstNhanVien;
>>>>>>> uuu
        }

        public List<ViewNhanVien> GetViewChiTietSps()
        {
<<<<<<< HEAD
            if (obj == null)
                return false;
            _inhanVienRepositories.DeleteNvFromDb(obj);
            return true;
        }

        public List<NhanVien> GetAllNv()
        {
            _lstNhanVien = _inhanVienRepositories.GetAllNvFromDb();
            return _lstNhanVien;
        }

        public List<NhanVienVm> ShowAllNhanVien()
        {
            var Show = from a in _inhanVienRepositories.GetAllNvFromDb()
                       join b in _icuaHangRepositories.GetCuaHangFromDb() on a.IdCh equals b.Id
                       join c in _ichucVuRepositories.GetChucVuFromDb() on a.IdCv equals c.Id
                       select new NhanVienVm()
                       {
                           Id = a.Id,
                           IdCv = a.IdCv,
                           IdCh = a.IdCh,
                           MaNv = a.MaNv,
                           HoTenNv = a.HoTenNv,
                           GioiTinh = a.GioiTinh,
                           NgaySinh = a.NgaySinh,
                           DiaChi = a.DiaChi,
                           CCCD = a.CCCD,
                           Sdt = a.Sdt,
                           Email = a.Email,
                           Anh = a.Anh,
                           TrangThai = a.TrangThai,
                           MaCH = b.MaCH,
                           TenCV = c.TenCV
                       };
            return Show.ToList();
=======
            _viewNhanVienslst = (from a in _INhanVienReps.GetNhanVien()
                                 join b in _ICuaHangReps.GetAll() on a.IdCh equals b.Id
                                 join c in _IChucVuReps.GetAll() on a.IdCv equals c.Id
                                 select new ViewNhanVien
                                 {
                                     Id = a.Id,
                                     MaNv = a.MaNv,
                                     HoTenNv = a.HoTenNv,
                                     Anh = a.Anh,
                                     GioiTinh = a.GioiTinh,
                                     NgaySinh = a.NgaySinh,
                                     CCCD = a.CCCD,
                                     Email = a.Email,
                                     Sdt = a.Sdt,
                                     MatKhau = a.MatKhau,
                                     ChucVu = c.TenCV,
                                     TenCuaHang = b.TenCH,
                                     DiaChi = a.DiaChi,
                                     TrangThai = a.TrangThai
                                 }).ToList();
            return _viewNhanVienslst;
        }

        public bool updateSanPhamChiTiet(ViewNhanVien nhanVien)
        {
            var x = _INhanVienReps.GetNhanVien().FirstOrDefault(p => p.Id == nhanVien.Id);
            x.MaNv = nhanVien.MaNv;
            x.HoTenNv = nhanVien.HoTenNv;
            x.Anh = nhanVien.Anh;
            x.GioiTinh = nhanVien.GioiTinh;
            x.NgaySinh = nhanVien.NgaySinh;
            x.CCCD = nhanVien.CCCD;
            x.Sdt = nhanVien.Sdt;
            x.Email = nhanVien.Email;
            x.MatKhau = nhanVien.MatKhau;
            x.IdCh = nhanVien.IdCh;
            x.IdCv = nhanVien.IdCv;
            x.DiaChi = nhanVien.DiaChi;
            x.TrangThai = nhanVien.TrangThai;
            _INhanVienReps.updateNhanVien(x);
            return true;
>>>>>>> uuu
        }

        public bool updateSanPhamChiTiets(NhanVien nhanVien)
        {
<<<<<<< HEAD
            var exist = _inhanVienRepositories.GetByNameEmail(obj.Email);
            if (exist != null || obj == null)
            {
                return false;
            }
            else
            {
                _inhanVienRepositories.UpdateNvFromDb(obj);
                return true;
            }
=======
            _INhanVienReps.updateNhanVien(nhanVien);
            return true;
>>>>>>> uuu
        }
    }
}
