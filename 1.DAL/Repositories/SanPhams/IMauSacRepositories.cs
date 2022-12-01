using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public interface IMauSacRepositories
    {
        bool add(MauSac obj);

        bool delete(MauSac obj);

        bool update(MauSac obj);

        MauSac getmaid(Guid id);

        List<MauSac> GetMauSacs();
    }
}
