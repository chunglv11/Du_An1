using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public interface IKichCoRepositories
    {
        bool add(KichCo obj);

        bool delete(KichCo obj);

        bool update(KichCo obj);
        List<KichCo> GetKichCos();
    }
}
