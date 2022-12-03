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
    public class SanPhamRepositories : ISanPhamRepositories
    {
        QLBH_Context _Context;
        List<SanPham> _sanphamlist;
        public SanPhamRepositories()
        {
            _Context = new QLBH_Context();
            _sanphamlist = new List<SanPham>();
        }
        public bool add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _Context.sanPhams.Add(obj);
            _Context.SaveChanges();
            return true;
        }

        public bool delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempoj = _Context.sanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _Context.sanPhams.Remove(obj);
            _Context.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _Context.sanPhams.ToList();
        }

        public bool update(SanPham obj)
        {
            if (obj == null) return false;
            var tempoj = _Context.sanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempoj.TenSp = obj.TenSp;
            tempoj.MaSp = obj.MaSp;
            _Context.sanPhams.Update(obj);
            _Context.SaveChanges();
            return true;
        }
    }
}
