using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _2.BUS.Services.CuaHangs
{
    public interface ICuaHangServices
    {
        bool AddCH(CuaHang obj);

        bool DeleteCH(CuaHang obj);

        bool UpdateCH(CuaHang obj);

        List<CuaHang> GetCuaHang();
    }
}
