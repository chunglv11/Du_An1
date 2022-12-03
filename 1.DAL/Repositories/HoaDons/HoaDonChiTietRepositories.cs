using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _1.DAL.Context;

namespace _1.DAL.Repositories.HoaDons
{
    public class HoaDonChiTietRepositories : IHoaDonChiTietRepositories
    {
        private QLBH_Context _context;
        private List<HoaDonChiTiet> _lstHDCT;
        public HoaDonChiTietRepositories()
        {
            _context = new QLBH_Context();
            _lstHDCT = new List<HoaDonChiTiet>();
        }
        public bool AddHdCTFromDb(HoaDonChiTiet obj)
        {
            try
            {
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteHdCTFromDb(HoaDonChiTiet obj)
        {
            throw new NotImplementedException();
        }

        public HoaDonChiTiet GetHoaDonCTById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonChiTiet> GetHoaDonCTFromDb()
        {
            throw new NotImplementedException();
        }

        public bool UpdateHdCTFromDb(HoaDonChiTiet obj)
        {
            throw new NotImplementedException();
        }
    }
}
