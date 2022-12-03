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
        bool AddNvFromDb(NhanVien obj);
        bool UpdateNvFromDb(NhanVien obj);
        bool DeleteNvFromDb(NhanVien obj);
        NhanVien GetByNameEmail(string email);
        List<NhanVien> GetAllNvFromDb();
    }
}
