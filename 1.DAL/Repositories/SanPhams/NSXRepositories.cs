using _1.DAL.Context;
using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public class NSXRepositories : INSXRepositories
    {
        QLBH_Context _Context;
        List<Nsx> _Nsxlist;

        public NSXRepositories()
        {
            _Context = new QLBH_Context();
            _Nsxlist = new List<Nsx>();
        }
        public bool add(Nsx obj)
        {
            _Context.Nsxes.Add(obj);
            _Context.SaveChanges();
            return true;
        }

        public bool delete(Nsx obj)
        {
            _Context.Nsxes.Remove(obj);
            _Context.SaveChanges();
            return true;
        }

        public List<Nsx> GetNSXs()
        {
            _Nsxlist =  _Context.Nsxes.ToList();
            return _Nsxlist;
        }

        public bool update(Nsx obj)
        {
            _Context.Nsxes.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
}
