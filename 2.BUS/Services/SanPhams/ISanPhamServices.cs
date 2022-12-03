using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface ISanPhamServices
    {
        string add(SanPham obj);

        string delete(SanPham obj);

        string update(SanPham obj);

        List<SanPham> GetAll();
        List<SanPham> GetAll(string input);
    }
}
