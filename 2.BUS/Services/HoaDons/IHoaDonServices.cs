using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _2.BUS.ViewModels;

namespace _2.BUS.Services.HoaDons
{
    public interface IHoaDonServices
    {
        string Add(ViewHoaDon obj);
        string Update(ViewHoaDon obj);
        string Delete(ViewHoaDon obj);
        List<ViewHoaDon> GetAll(string input);
        List<ViewHoaDon> GetAll();
    }
}
