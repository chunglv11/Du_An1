using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _2.BUS.ViewModels;

namespace _2.BUS.Services.HoaDons
{
    public interface IHoaDonChiTietService
    {
        string Add(ViewHoaDonChiTiet obj);
        string Update(ViewHoaDonChiTiet obj);
        string Delete(ViewHoaDonChiTiet obj);
        List<ViewHoaDonChiTiet> GetAll(Guid id);
        List<ViewHoaDonChiTiet> GetAll();
    }
}
