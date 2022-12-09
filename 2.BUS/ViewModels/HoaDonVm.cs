using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonVm
    {
        public Guid Id { get; set; }
        public Guid IdKh { get; set; }
        public Guid IdNv { get; set; }
        public string MaHD { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public DateTime? NgayShip { get; set; }
        public string? TenNguoiShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string? TenNguoiNhan { get; set; }
        public string? DiaChi { get; set; }
        public string? Sdt { get; set; }
        public decimal TongTien { get; set; }
        public int TinhTrang { get; set; }

        //Thuộc tính hiển thị
        public string TenKH { get; set; }
        public string TenNv { get; set; }

    }
}
