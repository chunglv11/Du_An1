using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class CuaHang
    {
        public Guid Id { get; set; }    
        public string MaCH { get; set; }      
        public string TenCH { get; set; }       
        public string DiaChi { get; set; }       
        public string ThanhPho { get; set; }       
        public string QuocGia { get; set; }
    }
}
