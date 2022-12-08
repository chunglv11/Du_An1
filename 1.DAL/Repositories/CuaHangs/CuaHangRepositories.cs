using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;

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
        public bool AddChFromDb(CuaHang obj)
        {
            try
            {
                //obj.Id = Guid.NewGuid();
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteChFromDb(CuaHang obj)
        {
            try
            {
                _context.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<CuaHang> GetCuaHangFromDb()
        {
            _lstCuaHang = _context.cuaHangs.ToList();
            return _lstCuaHang;
        }

        public bool UpdateChFromDb(CuaHang obj)
        {
            try
            {
                CuaHang ch = _context.cuaHangs.Find(obj.Id);
                ch.MaCH = obj.MaCH;
                ch.TenCH = obj.TenCH;
                ch.DiaChi = obj.DiaChi;
                ch.ThanhPho = obj.ThanhPho;
                ch.QuocGia = obj.QuocGia;
                _context.Update(ch);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
