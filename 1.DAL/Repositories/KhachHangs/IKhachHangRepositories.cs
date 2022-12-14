using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _1.DAL.Repositories.KhachHangs
{
    public interface IKhachHangRepositories
    {
        bool AddKhFromDb(KhachHang obj);

        bool DeleteKhFromDb(KhachHang obj);

        bool UpdateKhFromDb(KhachHang obj);

        List<KhachHang> GetKhachHangKhFromDb();
    }
}
