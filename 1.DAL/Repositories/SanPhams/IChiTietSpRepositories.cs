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
        bool addChiTietSP(ChiTietSp chiTietSP);
        bool updateChiTietSP(ChiTietSp chiTietSP);
        bool deleteChiTietSP(ChiTietSp chiTietSP);
        List<ChiTietSp> GetChiTietSP();
    }
}
