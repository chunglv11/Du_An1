using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using _3.PL.SanPham;
=======
using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanVien;
using _3.PL.Views.BanHang;
>>>>>>> update 1/12/2022
using _3.PL.Views;
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
            Application.Run(new FrmDongSP());
=======
            Application.Run(new FrmLogin());
>>>>>>> update 1/12/2022
        }
    }
}