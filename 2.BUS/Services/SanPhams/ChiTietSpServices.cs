using _1.DAL.Entities;
using _1.DAL.Repositories.SanPhams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class ChiTietSpServices:IChiTietSpServices
    {
        IChiTietSpRepositories _IChiTietSpRepos;
        List<ChiTietSp> _ListChiTietSp;

        public ChiTietSpServices()
        {
            _IChiTietSpRepos = new ChiTietSpRepositories();
            _ListChiTietSp = new List<ChiTietSp>();
        }

        public bool add(ChiTietSp obj)
        {
            _IChiTietSpRepos.add(obj);
            return true;
        }

        public bool delete(ChiTietSp obj)
        {
            _IChiTietSpRepos.delete(obj);
            return true;
        }

        public List<ChiTietSp> GetChiTietSps()
        {
            _ListChiTietSp = _IChiTietSpRepos.GetChiTietSps();
            return _ListChiTietSp;
        }

        public ChiTietSp getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool update(ChiTietSp obj)
        {
            _IChiTietSpRepos.update(obj);
            return true;
        }
    }
}
