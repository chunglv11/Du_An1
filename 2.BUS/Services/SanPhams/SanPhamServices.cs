using _1.DAL.Entities;
using _1.DAL.Repositories.NhanViens;
using _1.DAL.Repositories.SanPhams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class SanPhamServices : ISanPhamServices
    {
        ISanPhamRepositories _ISanPhamRepos;
        List<SanPham> _Listsanpham;

        public SanPhamServices()
        {
            _ISanPhamRepos = new SanPhamRepositories();
            _Listsanpham = new List<SanPham>();
        }

        public string add(SanPham obj)
        {
            _ISanPhamRepos.add(obj);
            return "Thành công";
        }

        public string delete(SanPham obj)
        {
            _ISanPhamRepos.delete(obj);
            return "Thành công";
        }

        public List<SanPham> GetAll()
        {
            _Listsanpham = _ISanPhamRepos.GetAll();
            return _Listsanpham;
        }

        public List<SanPham> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _ISanPhamRepos.GetAll().Where(c => c.TenSp.ToLower().Contains(input.ToLower()) || c.MaSp.ToLower().Contains(input.ToLower())).ToList();
        }

        public string update(SanPham obj)
        {
            _ISanPhamRepos.update(obj);
            return "Thành công";
        }
    }
}
