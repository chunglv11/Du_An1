using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _2.BUS.Services.KhachHangs
{
    public interface IKhachHangServices
    {
        bool AddKH(KhachHang obj);

        bool DeleteKH(KhachHang obj);

        bool UpdateKH(KhachHang obj);

        List<KhachHang> GetKhachHangKH();
    }
}
