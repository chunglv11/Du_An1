using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public interface IMauSacRepositories
    {
        public bool Add(MauSac obj);
        public bool Remove(MauSac obj);
        public bool Update(MauSac obj);
        public List<MauSac> GetAll();
        public string Check(string input);
    }
}
