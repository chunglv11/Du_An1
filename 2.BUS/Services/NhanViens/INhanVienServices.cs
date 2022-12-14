using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _2.BUS.ViewModels;
<<<<<<< HEAD
=======

>>>>>>> uuu
namespace _2.BUS.Services.NhanViens
{
    public interface INhanVienServices
    {
<<<<<<< HEAD
        bool AddNv(NhanVien obj);
        bool UpdateNv(NhanVien obj);
        bool DeleteNv(NhanVien obj);
        List<NhanVienVm> ShowAllNhanVien();
        List<NhanVien> GetAllNv();
=======
        bool addSanPhamChiTiet(ViewNhanVien nhanVien);
        bool updateSanPhamChiTiet(ViewNhanVien nhanVien);
        bool updateSanPhamChiTiets(NhanVien nhanVien);
        bool deleteSanPhamChiTiet(Guid idnv);
        List<NhanVien> GetNhanViens();
        List<ViewNhanVien> GetViewChiTietSps();
>>>>>>> uuu
    }
}
