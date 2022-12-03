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
        public bool addChiTietSP(ChiTietSp chiTietSP)
        {
            _Context.chiTietSps.Add(chiTietSP);
            _Context.SaveChanges();
            return _Context.SaveChanges() > 0;
        }
        public bool deleteChiTietSP(ChiTietSp chiTietSP)
        {
            _Context.chiTietSps.Remove(chiTietSP);
            _Context.SaveChanges();
            return true;
        }
        public List<ChiTietSp> GetChiTietSP()
        {
            _ChiTietSplist = _Context.chiTietSps.ToList();
            return _ChiTietSplist;
        }
        public bool updateChiTietSP(ChiTietSp chiTietSP)
        {
            ChiTietSp id = _Context.chiTietSps.Find(chiTietSP.Id);
            id.Anh = chiTietSP.Anh;
            id.MoTa = chiTietSP.MoTa;
            id.SoLuongTon= chiTietSP.SoLuongTon;
            id.GiaBan = chiTietSP.GiaBan;
            id.GiaNhap = chiTietSP.GiaNhap;
            id.TinhTrang = chiTietSP.TinhTrang;
            id.IdSp = chiTietSP.IdSp;
            id.IdDongSp = chiTietSP.IdDongSp;
            id.IdKichCo = chiTietSP.IdKichCo;
            id.IdMauSac = chiTietSP.IdMauSac;
            id.IdNsx = chiTietSP.IdNsx;
            _Context.chiTietSps.Update(id);
            _Context.SaveChanges();
            return true;
        }
    }
}
