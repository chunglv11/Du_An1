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

        public string Add(ChucVu obj)
        {
            _iChucVuRepos.Add(obj);
            return "Thành công";
        }

        public string Delete(ChucVu obj)
        {
            _iChucVuRepos.Delete(obj);
            return "Thành công";
        }

        public List<ChucVu> GetAll()
        {
            _lstChucVu = _iChucVuRepos.GetAll();
            return _lstChucVu;
        }

        public List<ChucVu> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _iChucVuRepos.GetAll().Where(c => c.TenCV.ToLower().Contains(input.ToLower()) || c.MaCV.ToLower().Contains(input.ToLower())).ToList();
        
    }

        public string Update(ChucVu obj)
        {
            _iChucVuRepos.Update(obj);
            return "Thành công";
        }
    }
}
