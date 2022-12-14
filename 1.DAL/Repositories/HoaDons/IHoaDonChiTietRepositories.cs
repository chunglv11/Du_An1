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
        bool addHDCT(HoaDonChiTiet hoadonCT);
        bool DeleteHDCT(HoaDonChiTiet hoadonCT);
        bool updateHDCT(HoaDonChiTiet hoadonCT);

        List<HoaDonChiTiet> GetHDCTFromDB();
    }
}
