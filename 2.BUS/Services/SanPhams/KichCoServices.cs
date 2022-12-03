using _1.DAL.Entities;
using _1.DAL.Repositories.SanPhams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class KichCoServices:IKichCoServices
    {
        IKichCoRepositories _IKichCoRepos;
        List<KichCo> _ListKichCo;

        public KichCoServices()
        {
            _IKichCoRepos = new KichCoRepositories();
            _ListKichCo = new List<KichCo>();
        }
        public bool add(KichCo obj)
        {
            _IKichCoRepos.add(obj);
            return true;
        }

        public bool delete(KichCo obj)
        {
            _IKichCoRepos.delete(obj);
            return true;
        }

        public List<KichCo> GetKichCo()
        {
            _ListKichCo = _IKichCoRepos.GetKichCos();
            return _ListKichCo;
        }


        public bool update(KichCo obj)
        {
            _IKichCoRepos.update(obj);
            return true;
        }
    }
}
