using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
using _3.PL.SanPham;

using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanVien;
using _3.PL.Views.BanHang;

using _3.PL.Views;
using _3.PL.Views.SanPham;

=======
using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanVien;
using _3.PL.Views.BanHang;
using _3.PL.SanPham;
>>>>>>> u
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
            Application.Run(new FrmBanHang());
>>>>>>> u

        }
    }
}