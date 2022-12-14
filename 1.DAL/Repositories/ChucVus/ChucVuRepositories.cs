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
        List<ChucVu> _lstChucVu;
        public ChucVuRepositories()
        {
            _Context = new QLBH_Context();
            _lstChucVu = new List<ChucVu>();  
        }

        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _Context.chucVus.Add(obj);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _Context.chucVus.FirstOrDefault(c => c.Id == obj.Id);
            _Context.Remove(tempobj);
            _Context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _Context.chucVus.ToList();
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _Context.chucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Id = obj.Id;
            tempobj.MaCV = obj.MaCV;
            tempobj.TenCV = obj.TenCV;
            _Context.chucVus.Update(tempobj);
            _Context.SaveChanges();
            return true;
        }
    }
}
