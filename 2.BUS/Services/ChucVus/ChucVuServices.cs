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
        IChucVuRepositories _iChucVuRepos;
        List<ChucVu> _lstChucVu;
        public ChucVuServices()
        {
            _iChucVuRepos = new ChucVuRepositories();
            _lstChucVu= new List<ChucVu>();
        }

        public bool AddCV(ChucVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            _iChucVuRepos.AddCv(obj);
            return true;
        }

        public bool DeleteCV(ChucVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            _iChucVuRepos.DeleteCv(obj);
            return true;
        }

        public List<ChucVu> GetAllChucVu()
        {
            _lstChucVu = _iChucVuRepos.GetChucVuFromDb().ToList();
            return _lstChucVu;
        }

        public ChucVu getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCV(ChucVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            _iChucVuRepos.UpdateCv(obj);
            return true;
        }
    }
}
