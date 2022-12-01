using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public interface IDongSpRepositories
    {
        public bool Add(DongSp obj);
        public bool Remove(DongSp obj);
        public bool Update(DongSp obj);
        public List<DongSp> GetAll();
    }
}
