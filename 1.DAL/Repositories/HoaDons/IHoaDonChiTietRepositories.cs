using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _1.DAL.Repositories.HoaDons
{
    public interface IHoaDonChiTietRepositories
    {
        bool AddHdCTFromDb(HoaDonChiTiet obj);

        bool DeleteHdCTFromDb(HoaDonChiTiet obj);

        bool UpdateHdCTFromDb(HoaDonChiTiet obj);

        HoaDonChiTiet GetHoaDonCTById(Guid id);

        List<HoaDonChiTiet> GetHoaDonCTFromDb();
    }
}
