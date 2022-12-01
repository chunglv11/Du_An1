using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.ChucVus
{
    public interface IChucVuRepositories
    {
        bool add(ChucVu obj);

        bool delete(ChucVu obj);

        bool update(ChucVu obj);

        ChucVu getmaid(Guid id);

        List<ChucVu> GetChucVus();
    }
}
