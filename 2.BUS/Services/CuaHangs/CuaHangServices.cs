using _1.DAL.Entities;
using _1.DAL.Repositories.CuaHangs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2.BUS.Services.CuaHangs
{
    public class CuaHangServices : ICuaHangServices
    {
        private ICuaHangRepositories _icuaHangRepositories;
        private List<CuaHang> _lstCuaHang;
        public CuaHangServices()
        {
            _icuaHangRepositories = new CuaHangRepositories();
            _lstCuaHang = new List<CuaHang>();
        }
        public bool AddCH(CuaHang obj)
        {
            if (obj == null)
                return false;
            _icuaHangRepositories.AddChFromDb(obj);
            return true;
        }

        public bool DeleteCH(CuaHang obj)
        {
            if (obj == null)
                return false;
            _icuaHangRepositories.DeleteChFromDb(obj);
            return true;
        }

        public List<CuaHang> GetCuaHang()
        {
            _lstCuaHang = _icuaHangRepositories.GetCuaHangFromDb().ToList();
            return _lstCuaHang;
        }

        public bool UpdateCH(CuaHang obj)
        {
            if (obj == null)
                return false;
            _icuaHangRepositories.UpdateChFromDb(obj);
            return true;
        }
    }
}
