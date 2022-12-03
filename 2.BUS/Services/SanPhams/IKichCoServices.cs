using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface IKichCoServices
    {
        bool add(KichCo obj);

        bool delete(KichCo obj);

        bool update(KichCo obj);

        List<KichCo> GetKichCo();
    }
}
