using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanVien;
using _3.PL.Views.BanHang;
<<<<<<< HEAD
using _3.PL.Views.ChucVu;
using _3.PL.Views.SanPham;
=======
using _3.PL.Views.SanPham;
using _3.PL.Views.CuaHangs;
using _3.PL.Views.ChucVus;
>>>>>>> 8/12/2022

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


<<<<<<< HEAD
            Application.Run(new FrmChiTietSP());
=======
           // Application.Run(new FrmCuaHang());
>>>>>>> 8/12/2022



        }
    }
}