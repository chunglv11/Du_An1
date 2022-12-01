using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface IMauSacServices
    {
        bool add(MauSac obj);

        bool delete(MauSac obj);

        bool update(MauSac obj);

        MauSac getmaid(Guid id);

        List<MauSac> GetMauSac();
    }
}
