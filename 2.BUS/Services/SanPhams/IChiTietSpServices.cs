using _1.DAL.Entities;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface IChiTietSpServices
    {
        bool addSanPhamChiTiet(ViewChiTietSP chiTietSP);
        bool updateSanPhamChiTiet(ViewChiTietSP chiTietSP);
        bool deleteSanPhamChiTiet(Guid idnv);
        List<ChiTietSp> GetChiTietSPs();
        List<ViewChiTietSP> GetViewChiTietSps();
    }
}
