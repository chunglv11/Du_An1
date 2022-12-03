using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services.SanPhams
{
    public interface IMauSacServices
    {
        public bool Add(MauSac obj);
        public bool Remove(MauSac obj);
        public bool Update(MauSac obj);
        public List<MauSac> GetAll();
        public List<MauSac> GetAll(string input);
    }
}
