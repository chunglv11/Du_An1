using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewChiTietSP
    {
        public Guid Id { get; set; }
        public Guid IdSp { get; set; }
        public Guid IdNsx { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdDongSp { get; set; }
        public Guid IdKichCo { get; set; }
        public string MoTa { get; set; }
        public int SoLuongTon { get; set; }
        public string Anh { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int TinhTrang { get; set; }

        public string TenSanPham { get; set; }
        public string TenNsx { get; set; }
        public string tenMauSac { get; set; }
        public string tenDongSp { get; set; }
        public string tenKichCo { get; set; }
    }
}
