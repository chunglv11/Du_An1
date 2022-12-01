using _1.DAL.Context;
using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public class KichCoRepositories : IKichCoRepositories
    {
        QLBH_Context _Context;
        List<KichCo> _kichcolist;

        public KichCoRepositories()
        {
            _Context = new QLBH_Context();
            _kichcolist = new List<KichCo>();
        }
        public bool add(KichCo obj)
        {
            _Context.kichCos.Add(obj);
            _Context.SaveChanges();
            return true;
        }

        public bool delete(KichCo obj)
        {
            _Context.kichCos.Remove(obj);
            _Context.SaveChanges();
            return true;
        }

        public List<KichCo> GetKichCos()
        {
            return _Context.kichCos.ToList();
        }

        public KichCo getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool update(KichCo obj)
        {
            _Context.kichCos.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
}
