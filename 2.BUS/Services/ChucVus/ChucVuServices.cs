using _1.DAL.Entities;
using _1.DAL.Repositories.ChucVus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.ChucVus
{
    public class ChucVuServices : IChucVuServices
    {
        IChucVuRepositories _IChucVuRepos;
        List<ChucVu> _ListChucVu;
        public ChucVuServices()
        {
            _IChucVuRepos = new ChucVuRepositories();
            _ListChucVu= new List<ChucVu>();
        }

        public bool add(ChucVu obj)
        {
            _IChucVuRepos.add(obj);
            return true;
        }

        public bool delete(ChucVu obj)
        {
            _IChucVuRepos.delete(obj);
            return true;
        }

        public List<ChucVu> GetChucVus()
        {
            _ListChucVu = _IChucVuRepos.GetChucVus();
            return _ListChucVu;
        }

        public ChucVu getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool update(ChucVu obj)
        {
            _IChucVuRepos.update(obj);
            return true;
        }
    }
}
