using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _1.DAL.Repositories.HoaDons
{
    public interface IHoaDonRepositories
    {
        bool AddHdFromDb(HoaDon obj);

        bool DeleteHdFromDb(HoaDon obj);

        bool UpdateHdFromDb(HoaDon obj);

        HoaDon GetHoaDonById(Guid id);

        List<HoaDon> GetHoaDonFromDb();
    }
}
