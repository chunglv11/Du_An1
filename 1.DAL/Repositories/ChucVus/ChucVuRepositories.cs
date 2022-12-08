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

        public bool AddCv(ChucVu obj)
        {
            try
            {
                _Context.Add(obj);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool DeleteCv(ChucVu obj)
        {
            try
            {
                _Context.Remove(obj);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public List<ChucVu> GetChucVuFromDb()
        {
            _lstChucVu = _Context.chucVus.ToList();
            return _lstChucVu;
        }

        public ChucVu getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCv(ChucVu obj)
        {
            try
            {
                ChucVu cv = _Context.chucVus.Find(obj.Id);
                cv.MaCV = obj.MaCV;
                cv.TenCV = obj.TenCV;
                _Context.Update(cv);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
