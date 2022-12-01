using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface IChiTietSpServices
    {
        bool add(ChiTietSp obj);

        bool delete(ChiTietSp obj);

        bool update(ChiTietSp obj);

        ChiTietSp getmaid(Guid id);

        List<ChiTietSp> GetChiTietSps();
    }
}
