using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using _3.PL.Views.DangNhap;
using _3.PL.Views.NhanViens;
using _3.PL.Views.BanHang;
using _3.PL.Views.SanPhams;
using _3.PL.Views.CuaHangs;
using _3.PL.Views.ChucVus;
using _3.PL.Views.KhachHang;

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

            Application.Run(new _Main());


        }
    }
}