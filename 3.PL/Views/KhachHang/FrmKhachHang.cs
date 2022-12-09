using _2.BUS.Services.KhachHangs;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.KhachHang
{
    public partial class FrmKhachHang : Form
    {
        IKhachHangServices _IkhachHangServices;
        Guid _id;
        public FrmKhachHang()
        {
            InitializeComponent();
            _IkhachHangServices = new KhachHangServices();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            Dgrid_KH.ColumnCount = 5;
            Dgrid_KH.Columns[0].Name = "STT";
            Dgrid_KH.Columns[1].Name = "Mã";
            Dgrid_KH.Columns[2].Name = "Họ Và Tên";
            Dgrid_KH.Columns[3].Name = "SĐT ";
            Dgrid_KH.Columns[4].Name = "Địa Chỉ";
            Dgrid_KH.Rows.Clear();
            foreach (var x in _IkhachHangServices.GetAll())
            {
                Dgrid_KH.Rows.Add(stt++, x.Id, x.MaKH, x.HoTenKH, x.Sdt, x.DiaChi);
            }
        }
        public ViewKhachHang GetData()
        {
            ViewKhachHang kh = new ViewKhachHang()
            {
                Id = Guid.Empty,
                MaKH = txt_Ma.Text,
                HoTenKH = txt_HovaTen.Text,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diaChi.Text
            };
            return kh;
        }


        private void Dgrid_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(Dgrid_KH.CurrentRow.Cells[1].Value.ToString());
            var KH = _IkhachHangServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_Ma.Text = KH.MaKH;
            txt_HovaTen.Text = KH.HoTenKH;
            txt_sdt.Text = KH.Sdt;
            txt_diaChi.Text = KH.DiaChi;
        }

        private void txt_HovaTen_Leave(object sender, EventArgs e)
        {
            txt_HovaTen.Text = Utilities.Utilities.VietHoaChuCaiDau(txt_HovaTen.Text);
        }

        private void btn_KH_Them_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn thêm ko?", "Thông báo", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                MessageBox.Show(_IkhachHangServices.Add(GetData()));
                LoadData();
            }
            if (di == DialogResult.No)
            {
                return;
            }
        }

        private void btn_KH_TK_Click(object sender, EventArgs e)
        {
            int stt = 1;
            Dgrid_KH.ColumnCount = 10;
            Dgrid_KH.Columns[1].Name = "STT";
            Dgrid_KH.Columns[2].Name = "Mã";
            Dgrid_KH.Columns[3].Name = "Họ Và Tên";
            Dgrid_KH.Columns[4].Name = "SĐT";
            Dgrid_KH.Columns[5].Name = "Địa Chỉ";
            Dgrid_KH.Rows.Clear();
            foreach (var x in _IkhachHangServices.GetAll(tbt_KH_TK.Text))
            {
                Dgrid_KH.Rows.Add(stt++, x.Id, x.MaKH,x.HoTenKH,x.Sdt,x.DiaChi );
            }
        }
    }
}
