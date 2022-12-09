using _1.DAL.Entities;
using _1.DAL.Repositories.KhachHangs;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.KhachHangs
{
    public class KhachHangServices : IKhachHangServices
    {
        private IKhachHangRepositories _ikhachHangRepositories;
        private List<KhachHang> _lstKhachHang;
        public KhachHangServices()
        {
            _ikhachHangRepositories = new KhachHangRepositories();
            _lstKhachHang = new List<KhachHang>();
        }

        public string Add(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                Id = obj.Id,
                MaKH = obj.MaKH,
                HoTenKH = obj.HoTenKH,
                Sdt = obj.Sdt,
                DiaChi= obj.DiaChi,
            };
            if (_ikhachHangRepositories.AddKhFromDb(KH)) return "Thêm thành công";
            return "không thành công";
        }

        public string Delete(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                Id = obj.Id,
                MaKH = obj.MaKH,
                HoTenKH = obj.HoTenKH,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
            };
            if (_ikhachHangRepositories.DeleteKhFromDb(KH)) return "Xóa thành công";
            return "không thành công";
        }

  
        public List<ViewKhachHang> GetAll()
        {
            List<ViewKhachHang> lstKH = new List<ViewKhachHang>();
            lstKH = (from n in _ikhachHangRepositories.GetKhachHangKhFromDb()
                     select new ViewKhachHang
                     {
                         Id = n.Id,
                         MaKH = n.MaKH,
                         HoTenKH = n.HoTenKH,
                         Sdt = n.Sdt,
                         DiaChi = n.DiaChi
                     }).ToList();
            return lstKH;
        }

        public List<ViewKhachHang> GetAll(string input)
        {
            List<ViewKhachHang> lstKH = new List<ViewKhachHang>();
            lstKH = (from n in _ikhachHangRepositories.GetKhachHangKhFromDb()
                     where n.HoTenKH.Contains(input) || n.MaKH.Contains(input) || n.Sdt.StartsWith(input)
                     select new ViewKhachHang
                     {
                         Id = n.Id,
                         MaKH = n.MaKH,
                         HoTenKH = n.HoTenKH,
                         Sdt = n.Sdt,
                         DiaChi = n.DiaChi,
                     }).ToList();
            return lstKH;
        }

        public string Update(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                Id = obj.Id,
                MaKH = obj.MaKH,
                HoTenKH = obj.HoTenKH,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
            };
            if (_ikhachHangRepositories.UpdateKhFromDb(KH)) return "Sửa thành công";
            return "không thành công";
        }

    }
}
