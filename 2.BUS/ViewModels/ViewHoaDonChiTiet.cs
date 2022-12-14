using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDonChiTiet
    {
        public Guid IdHoaDon { get; set; }

        public Guid IdChiTietSp { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public string TenSP { get; set; }
    }
}
