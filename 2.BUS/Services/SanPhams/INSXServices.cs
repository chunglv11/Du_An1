using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface INSXServices
    {
        bool add(Nsx obj);

        bool delete(Nsx obj);

        bool update(Nsx obj);

        List<Nsx> GetNsx();
    }
}
