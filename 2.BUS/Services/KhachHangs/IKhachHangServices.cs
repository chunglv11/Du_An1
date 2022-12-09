using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _2.BUS.ViewModels;

namespace _2.BUS.Services.KhachHangs
{
    public interface IKhachHangServices
    {
        string Add(ViewKhachHang obj);
        string Update(ViewKhachHang obj);
        string Delete(ViewKhachHang obj);
        List<ViewKhachHang> GetAll();
        List<ViewKhachHang> GetAll(string input);
    }
}
