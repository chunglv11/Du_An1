using _1.DAL.Entities;
using _2.BUS.ViewModels;
using _1.DAL.Repositories.NhanViens;
using _1.DAL.Repositories.CuaHangs;
using _1.DAL.Repositories.ChucVus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.NhanViens
{
    public class NhanVienServices : INhanVienServices
    {
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
        }

        public bool DeleteNv(NhanVien obj)
        {
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
        }

        public bool UpdateNv(NhanVien obj)
        {
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
        }
    }
}
