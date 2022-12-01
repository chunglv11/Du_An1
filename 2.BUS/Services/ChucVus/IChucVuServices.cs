using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.ChucVus
{
    public interface IChucVuServices
    {
        bool add(ChucVu obj);

        bool delete(ChucVu obj);

        bool update(ChucVu obj);

        ChucVu getmaid(Guid id);

        List<ChucVu> GetChucVus();
    }
}
