using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewNhanVien
    {
        public Guid Id { get; set; }
        public Guid IdCh { get; set; }
        public Guid IdCv { get; set; }
        public string MaNv { get; set; }
        public string HoTenNv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string? MatKhau { get; set; }
        public string Anh { get; set; }
        public int TrangThai { get; set; }
        public string TenCuaHang { get; set; }
        public string ChucVu { get; set; }
    }
}
