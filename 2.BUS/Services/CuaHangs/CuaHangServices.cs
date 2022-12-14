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

        public string Add(CuaHang obj)
        {
            _icuaHangRepositories.Add(obj);
            return "Thành công";
        }

        public string Delete(CuaHang obj)
        {
            _icuaHangRepositories.Delete(obj);
            return "Thành công";
        }

        public List<CuaHang> GetAll()
        {
            _lstCuaHang = _icuaHangRepositories.GetAll();
            return _lstCuaHang;
        }

        public List<CuaHang> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _icuaHangRepositories.GetAll().Where(c => c.TenCH.ToLower().Contains(input.ToLower()) || c.MaCH.ToLower().Contains(input.ToLower())).ToList();
        }

        public string Update(CuaHang obj)
        {
            _icuaHangRepositories.Update(obj);
            return "Thành công";
        }
    }
}
