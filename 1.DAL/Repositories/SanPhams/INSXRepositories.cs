using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public interface INSXRepositories
    {
        bool add(Nsx obj);

        bool delete(Nsx obj);

        bool update(Nsx obj);

        Nsx getmaid(Guid id);

        List<Nsx> GetNSXs();
    }
}
