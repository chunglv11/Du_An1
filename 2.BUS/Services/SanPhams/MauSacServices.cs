using _1.DAL.Entities;
using _1.DAL.Repositories.SanPhams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class MauSacServices : IMauSacServices
    {
        IMauSacRepositories _IMauSacRepos;
        List<MauSac> _ListMauSac;

        public MauSacServices()
        {
            _IMauSacRepos = new MauSacRepositories();
            _ListMauSac = new List<MauSac>();
        }
        public bool add(MauSac obj)
        {
            _IMauSacRepos.add(obj);
            return true;
        }

        public bool delete(MauSac obj)
        {
            _IMauSacRepos.delete(obj);
            return true;
        }

        public MauSac getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<MauSac> GetMauSac()
        {
            _ListMauSac = _IMauSacRepos.GetMauSacs();
            return _ListMauSac;
        }

        public bool update(MauSac obj)
        {
            _IMauSacRepos.update(obj);
            return true;
        }
    }
}
