using _1.DAL.Context;
using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.SanPhams
{
    public class MauSacRepositories : IMauSacRepositories
    {
        QLBH_Context _Context;
        List<MauSac> _MauSaclist;

        public MauSacRepositories()
        {
            _Context = new QLBH_Context();
            _MauSaclist = new List<MauSac>();
        }
        public bool Add(MauSac obj)
        {
            _Context.mauSacs.Add(obj);
            _Context.SaveChanges();
            return true;
        }
        public string Check(string input)
        {
            throw new NotImplementedException();
        }
        public List<MauSac> GetAll()
        {
            _MauSaclist = _Context.mauSacs.ToList();
            return _MauSaclist;
        }
        public bool Remove(MauSac obj)
        {
            _Context.mauSacs.Remove(obj);
            _Context.SaveChanges();
            return true;
        }
        public bool Update(MauSac obj)
        {
            _Context.mauSacs.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
    
}
