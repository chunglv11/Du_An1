using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;

namespace _2.BUS.Services.HoaDons
{
    public interface IHoaDonChiTietService
    {
        bool AddHdCT(HoaDonChiTiet obj);

        bool DeleteHdCT(HoaDonChiTiet obj);

        bool UpdateHdCT(HoaDonChiTiet obj);

        List<HoaDonChiTiet> GetHoaDonCT();
    }
}
