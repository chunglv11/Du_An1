using _1.DAL.Context;
using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories.ChucVus
{
    public class ChucVuRepositories : IChucVuRepositories
    {
        QLBH_Context _Context;
        List<ChucVu> _ChucVuList;
        public ChucVuRepositories()
        {
            _Context = new QLBH_Context();
            _ChucVuList = new List<ChucVu>();  
        }

        public bool add(ChucVu obj)
        {
            _Context.chucVus.Add(obj);
            _Context.SaveChanges();
            return true;
        }

        public bool delete(ChucVu obj)
        {
            _Context.chucVus.Remove(obj);
            _Context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetChucVus()
        {
            return _Context.chucVus.ToList();
        }

        public ChucVu getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool update(ChucVu obj)
        {
            _Context.chucVus.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
}
