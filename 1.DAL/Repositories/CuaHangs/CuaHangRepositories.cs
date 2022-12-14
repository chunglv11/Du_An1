using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Repositories.CuaHangs
{
    public class CuaHangRepositories : ICuaHangRepositories
    {
        private QLBH_Context _context;
        private List<CuaHang> _lstCuaHang;
        public CuaHangRepositories()
        {
            _context = new QLBH_Context();
            _lstCuaHang = new List<CuaHang>();
        }

        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            _context.cuaHangs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _context.cuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _context.cuaHangs.ToList();
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj =  _context.cuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Id = obj.Id;
            tempobj.MaCH = obj.MaCH;
            tempobj.TenCH = obj.TenCH;
            _context.cuaHangs.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
