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
        bool AddCV(ChucVu obj);

        bool DeleteCV(ChucVu obj);

        bool UpdateCV(ChucVu obj);

        ChucVu getmaid(Guid id);

        List<ChucVu> GetAllChucVu();
    }
}
