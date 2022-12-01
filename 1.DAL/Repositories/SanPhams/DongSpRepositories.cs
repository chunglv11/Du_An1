using _1.DAL.Context;
using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public class DongSpRepositories : IDongSpRepositories
    {
        QLBH_Context _Context;
        List<DongSp> _DongSplist;

        public DongSpRepositories()
        {
            _Context = new QLBH_Context();
            _DongSplist = new List<DongSp>();
        }

        public bool Add(DongSp obj)
        {
            _Context.dongSps.Add(obj);
            _Context.SaveChanges();
            return true;
        }
        public List<DongSp> GetAll()
        {
            _DongSplist = _Context.dongSps.ToList();
            return _DongSplist;
        }
        public bool Remove(DongSp obj)
        {
            _Context.dongSps.Remove(obj);
            _Context.SaveChanges();
            return true;
        }
        public bool Update(DongSp obj)
        {
            _Context.dongSps.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
}
