using _1.DAL.Entities;
using _1.DAL.Repositories.SanPhams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class DongSpServices:IDongSpServices
    {
        IDongSpRepositories _IDongSpRepos;

        public DongSpServices()
        {
            _IDongSpRepos = new DongSpRepositories();
        }
        public bool Add(DongSp obj)
        {
            _IDongSpRepos.Add(obj);
            return true;
        }
        public List<DongSp> GetAll()
        {
            return _IDongSpRepos.GetAll();
        }

        public List<DongSp> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _IDongSpRepos.GetAll().Where(c => c.TenDsp.ToLower().Contains(input.ToLower()) || c.MaDsp.ToLower().Contains(input.ToLower())).ToList();
        }
        public bool Remove(DongSp obj)
        {
            _IDongSpRepos.Remove(obj);
            return true;
        }
        public bool Update(DongSp obj)
        {
            _IDongSpRepos.Update(obj);
            return true;
        }
    }
}
