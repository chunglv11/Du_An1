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
        public bool add(SanPham obj)
        {
            _ISanPhamRepos.add(obj);
            return true;
        }

        public bool delete(SanPham obj)
        {
            _ISanPhamRepos.delete(obj);
            return true;
        }

        public SanPham getmaid(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<SanPham> GetSanPhams()
        {
            _Listsanpham = _ISanPhamRepos.GetSanPhams();
            return _Listsanpham;
        }

        public bool update(SanPham obj)
        {
            _ISanPhamRepos.update(obj);
            return true;
        }
    }
}
