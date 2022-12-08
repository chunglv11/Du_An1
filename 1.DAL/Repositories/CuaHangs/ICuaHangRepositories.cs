using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _1.DAL.Repositories.CuaHangs
{
    public interface ICuaHangRepositories
    {
        bool AddChFromDb(CuaHang obj);

        bool DeleteChFromDb(CuaHang obj);

        bool UpdateChFromDb(CuaHang obj);

        List<CuaHang> GetCuaHangFromDb();
    }
}
