using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewKhachHang
    {
        public Guid Id { get; set; }
        public string MaKH { get; set; }
        public string? HoTenKH { get; set; }
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }
    }
}
