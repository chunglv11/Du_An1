﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using _2.BUS.ViewModels;
namespace _2.BUS.Services.NhanViens
{
    public interface INhanVienServices
    {
        bool AddNv(NhanVien obj);
        bool UpdateNv(NhanVien obj);
        bool DeleteNv(NhanVien obj);
        List<NhanVienVm> ShowAllNhanVien();
        List<NhanVien> GetAllNv();
    }
}
