using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class HoaDonChiTiet
    {
        public Guid IdHoaDon { get; set; }
        
        public Guid IdChiTietSp { get; set; }
        public int SoLuong { get; set; }    
        public decimal DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ChiTietSp ChiTietSp { get; set; }
    }
}
