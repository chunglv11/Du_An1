using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class ChiTietSp
    {
        public Guid Id { get; set; }       
        public Guid IdSp { get; set; }
        public Guid IdNsx { get; set; }
        public Guid IdMauSac { get; set; }    
        public Guid IdDongSp { get; set; }              
        public Guid IdKichCo { get; set; }              
        public string MoTa { get; set; }
        public int SoLuongTon { get; set; }       
        public string ? Anh { get; set; }       
        public decimal GiaNhap { get; set; }        
        public decimal GiaBan { get; set; }
        public int TinhTrang { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual Nsx Nsx { get; set; }
        public virtual MauSac MauSac { get; set; }
        public virtual DongSp DongSp { get; set; }
        public virtual KichCo KichCo { get; set; }
    }
}
