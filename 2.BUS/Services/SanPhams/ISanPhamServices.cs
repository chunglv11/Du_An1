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
        bool add(SanPham obj);

        bool delete(SanPham obj);

        bool update(SanPham obj);

        SanPham getmaid(Guid id);

        List<SanPham> GetSanPhams();
    }
}
