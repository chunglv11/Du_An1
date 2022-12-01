using _1.DAL.Context;
using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public class ChiTietSpRepositories : IChiTietSpRepositories
    {
        QLBH_Context _Context;
        List<ChiTietSp> _ChiTietSplist;

        public ChiTietSpRepositories()
        {
            _Context = new QLBH_Context();
            _ChiTietSplist = new List<ChiTietSp>();
        }
        public bool add(ChiTietSp obj)
        {
            _Context.chiTietSps.Add(obj);
            _Context.SaveChanges();
            return true;
        }

        public bool delete(ChiTietSp obj)
        {
            _Context.chiTietSps.Remove(obj);
            _Context.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetChiTietSps()
        {
            return _Context.chiTietSps.ToList();
        }

        public ChiTietSp getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool update(ChiTietSp obj)
        {
            _Context.chiTietSps.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
}
