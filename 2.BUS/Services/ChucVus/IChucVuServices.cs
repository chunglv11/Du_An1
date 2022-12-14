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
        string Add(ChucVu obj);
        string Update(ChucVu obj);
        string Delete(ChucVu obj);
        List<ChucVu> GetAll();
        List<ChucVu> GetAll(string input);
    }
}
