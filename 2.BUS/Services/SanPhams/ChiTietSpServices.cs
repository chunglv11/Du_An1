using _1.DAL.Entities;
using _1.DAL.Repositories.SanPhams;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public class ChiTietSpServices : IChiTietSpServices
    {
        IChiTietSpRepositories _IChiTietSpRepos;
        ISanPhamRepositories _ISanPhamRepos;
        IDongSpRepositories _IDongSPRepos;
        IKichCoRepositories _IKichCoRepos;
        IMauSacRepositories _IMauSacRepos;
        INSXRepositories _INSXRepos;
        List<ChiTietSp> _ListChiTietSp;
        List<ViewChiTietSP> _ViewChiTietSp;

        public ChiTietSpServices()
        {
            _IChiTietSpRepos = new ChiTietSpRepositories();
            _ISanPhamRepos = new SanPhamRepositories();
            _IDongSPRepos = new DongSpRepositories();
            _IKichCoRepos = new KichCoRepositories();
            _IMauSacRepos = new MauSacRepositories();
            _INSXRepos = new NSXRepositories();
            _ListChiTietSp = new List<ChiTietSp>();
            _ViewChiTietSp = new List<ViewChiTietSP>();
        }

        public bool addSanPhamChiTiet(ViewChiTietSP chiTietSP)
        {
            var ctsp = new ChiTietSp()
            {
                Id = chiTietSP.Id,
                IdSp = chiTietSP.IdSp,
                IdDongSp = chiTietSP.IdDongSp,
                IdKichCo = chiTietSP.IdKichCo,
                IdMauSac = chiTietSP.IdMauSac,
                IdNsx = chiTietSP.IdNsx,
                MoTa = chiTietSP.MoTa,
                SoLuongTon = chiTietSP.SoLuongTon,
                Anh = chiTietSP.Anh,
                GiaNhap = chiTietSP.GiaNhap,
                GiaBan = chiTietSP.GiaBan,
                TinhTrang = chiTietSP.TinhTrang,
            };
            return _IChiTietSpRepos.addChiTietSP(ctsp);
        }

        public bool deleteSanPhamChiTiet(Guid idnv)
        {
            var x = _IChiTietSpRepos.GetChiTietSP().FirstOrDefault(p => p.Id == idnv);
            _IChiTietSpRepos.deleteChiTietSP(x);
            return true;
        }

        public List<ChiTietSp> GetChiTietSPs()
        {
            _ListChiTietSp = _IChiTietSpRepos.GetChiTietSP().ToList();
            return _ListChiTietSp;
        }

        public List<ViewChiTietSP> GetViewChiTietSps()
        {
            _ViewChiTietSp = (from a in _IChiTietSpRepos.GetChiTietSP()
                              join b in _ISanPhamRepos.GetAll() on a.IdSp equals b.Id
                              join c in _IDongSPRepos.GetAll() on a.IdDongSp equals c.Id
                              join d in _IKichCoRepos.GetKichCos() on a.IdKichCo equals d.Id
                              join e in _IMauSacRepos.GetAll() on a.IdMauSac equals e.Id
                              join f in _INSXRepos.GetNSXs() on a.IdNsx equals f.Id
                              select new ViewChiTietSP
                              {
                                  Id = a.Id,
                                  //Ma = a.Ma,
                                  IdSp = a.IdSp,
                                  IdDongSp = a.IdDongSp,
                                  IdKichCo = a.IdKichCo,
                                  IdMauSac = a.IdMauSac,
                                  IdNsx = a.IdNsx,
                                  MoTa = a.MoTa,
                                  SoLuongTon = a.SoLuongTon,
                                  Anh = a.Anh,
                                  GiaBan = a.GiaBan,
                                  GiaNhap = a.GiaNhap,
                                  TinhTrang = a.TinhTrang,
                                  TenSanPham = b.TenSp,
                                  tenDongSp = c.TenDsp,
                                  tenKichCo = d.TenKc,
                                  tenMauSac = e.TenMs,
                                  TenNsx = f.TenNsx
                              }).ToList();
            return _ViewChiTietSp;
        }

        public bool updateSanPhamChiTiet(ViewChiTietSP chiTietSP)
        {
            var x = _IChiTietSpRepos.GetChiTietSP().FirstOrDefault(p => p.Id == chiTietSP.Id);
            x.IdSp = chiTietSP.IdSp;
            x.IdDongSp = chiTietSP.IdDongSp;
            x.IdKichCo = chiTietSP.IdKichCo;
            x.IdMauSac = chiTietSP.IdNsx;
            x.MoTa = chiTietSP.MoTa;
            x.SoLuongTon = chiTietSP.SoLuongTon;
            x.Anh = chiTietSP.Anh;
            x.GiaNhap = chiTietSP.GiaNhap;
            x.GiaBan = chiTietSP.GiaBan;
            x.TinhTrang = chiTietSP.TinhTrang;
            _IChiTietSpRepos.updateChiTietSP(x);
            return true;
        }
    }
}
