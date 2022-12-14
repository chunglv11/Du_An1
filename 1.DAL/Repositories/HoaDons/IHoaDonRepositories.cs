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
        bool addHoaDon(HoaDon hoadon);
        bool DeleteHoaDon(HoaDon hoadon);
        bool updateHoaDon(HoaDon hoadon);

        List<HoaDon> GetHoaDonFromDB();

    }
}
