using _1.DAL.Entities;
using _1.DAL.Repositories.KhachHangs;
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
        public bool AddKH(KhachHang obj)
        {
            if (obj == null)
                return false;
            _ikhachHangRepositories.AddKhFromDb(obj);
            return true;
        }

        public bool DeleteKH(KhachHang obj)
        {
            if (obj == null)
                return false;
            _ikhachHangRepositories.DeleteKhFromDb(obj);
            return true;
        }

        public List<KhachHang> GetKhachHangKH()
        {
            _lstKhachHang = _ikhachHangRepositories.GetKhachHangKhFromDb();
            return _lstKhachHang;
        }

        public bool UpdateKH(KhachHang obj)
        {
            if (obj == null)
                return false;
            _ikhachHangRepositories.UpdateKhFromDb(obj);
            return true;
        }
    }
}
