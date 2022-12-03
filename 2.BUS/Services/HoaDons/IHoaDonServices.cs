using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _2.BUS.Services.HoaDons
{
    public interface IHoaDonServices
    {
        bool AddHd(HoaDon obj);

        bool DeleteHd(HoaDon obj);

        bool UpdateHd(HoaDon obj);

        List<HoaDon> GetHoaDon();
    }
}
