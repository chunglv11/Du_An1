using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public interface IChiTietSpRepositories
    {
        bool add(ChiTietSp obj);

        bool delete(ChiTietSp obj);

        bool update(ChiTietSp obj);

        ChiTietSp getmaid(Guid id);

        List<ChiTietSp> GetChiTietSps();
    }
}
