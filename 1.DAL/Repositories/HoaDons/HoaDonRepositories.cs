using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;

namespace _1.DAL.Repositories.HoaDons
{
    public class HoaDonRepositories : IHoaDonRepositories
    {
        private QLBH_Context _context;
        private List<HoaDon> _lstHoaDon;
        public HoaDonRepositories()
        {
            _context = new QLBH_Context();
            _lstHoaDon = new List<HoaDon>();
        }
        public bool AddHdFromDb(HoaDon obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteHdFromDb(HoaDon obj)
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

        public HoaDon GetHoaDonById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDon> GetHoaDonFromDb()
        {
            _lstHoaDon = _context.hoaDons.ToList();
            return _lstHoaDon;
        }

        public bool UpdateHdFromDb(HoaDon obj)
        {
            try
            {
                _context.Update(obj);
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
