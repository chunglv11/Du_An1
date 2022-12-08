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
        bool AddCv(ChucVu obj);

        bool DeleteCv(ChucVu obj);

        bool UpdateCv(ChucVu obj);

        ChucVu getmaid(Guid id);

        List<ChucVu> GetChucVuFromDb();
    }
}
