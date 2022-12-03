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

        public MauSacServices()
        {
            _IMauSacRepos = new MauSacRepositories();
        }
        public bool Add(MauSac obj)
        {
            _IMauSacRepos.Add(obj);
            return true;
        }
        public List<MauSac> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _IMauSacRepos.GetAll().Where(c => c.TenMs.ToLower().Contains(input.ToLower()) || c.MaMs.ToLower().Contains(input.ToLower())).ToList();
        }

        public List<MauSac> GetAll()
        {
            return _IMauSacRepos.GetAll();
        }

        public bool Remove(MauSac obj)
        {
            _IMauSacRepos.Remove(obj);
            return true;
        }
        public bool Update(MauSac obj)
        {
            _IMauSacRepos.Update(obj);
            return true;
        }
    }
}
