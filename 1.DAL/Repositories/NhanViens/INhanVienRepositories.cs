using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _1.DAL.Repositories.NhanViens
{
    public interface INhanVienRepositories
    {
        bool addNhanVien(NhanVien nhanVien);
        bool updateNhanVien(NhanVien nhanVien);
        bool deleteNhanVien(NhanVien nhanVien);
        List<NhanVien> GetNhanVien();
        NhanVien GetNhanVien(string ma, string matkhau);
        NhanVien GetCheck(string Email);
        NhanVien GetCheckPass(string Pass);
    }
}
