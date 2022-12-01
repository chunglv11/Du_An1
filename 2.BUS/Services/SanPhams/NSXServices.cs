using _1.DAL.Entities;
using _1.DAL.Repositories.SanPhams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class NSXServices : INSXServices
    {
        INSXRepositories _INSXRepos;
        List<Nsx> _ListNSX;
        public NSXServices()
        {
            _INSXRepos = new NSXRepositories();
            _ListNSX = new List<Nsx>();
        }
        public bool add(Nsx obj)
        {
            _INSXRepos.add(obj);
            return true;
        }

        public bool delete(Nsx obj)
        {
            _INSXRepos.delete(obj);
            return true;
        }

        public Nsx getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Nsx> GetNsx()
        {
            _ListNSX = _INSXRepos.GetNSXs();
            return _ListNSX;
        }

        public bool update(Nsx obj)
        {
            _INSXRepos.update(obj);
            return true;
        }
    }
}
