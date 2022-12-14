using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface IDongSpServices
    {
        public bool Add(DongSp obj);
        public bool Remove(DongSp obj);
        public bool Update(DongSp obj);
        public List<DongSp> GetAll();
        public List<DongSp> GetAll(string input);
    }
}
