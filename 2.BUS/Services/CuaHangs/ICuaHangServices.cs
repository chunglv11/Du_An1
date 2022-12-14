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
        string Add(CuaHang obj);
        string Update(CuaHang obj);
        string Delete(CuaHang obj);
        List<CuaHang> GetAll();
        List<CuaHang> GetAll(string input);
    }
}
