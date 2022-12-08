using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services.CuaHangs;
using _1.DAL.Entities;

namespace _3.PL.Views.CuaHangs
{
    public partial class FrmCuaHang : Form
    {
        private ICuaHangServices _icuaHangServices;
        private CuaHang _CH;
        private Guid _id;
        
        public FrmCuaHang()
        {
            InitializeComponent();
            _icuaHangServices = new CuaHangServices();
            _CH = new CuaHang();
            LoadData();
        }
        public void LoadData()
        {
            dgv_ShowCuaHang.ColumnCount = 6;
            dgv_ShowCuaHang.Rows.Clear();
            dgv_ShowCuaHang.Columns[0].Name = "Id";
            dgv_ShowCuaHang.Columns[0].Visible = false;
            dgv_ShowCuaHang.Columns[1].Name = "Mã cửa hàng";
            dgv_ShowCuaHang.Columns[2].Name = "Tên cửa hàng";
            dgv_ShowCuaHang.Columns[3].Name = "Địa chỉ";
            dgv_ShowCuaHang.Columns[4].Name = "Thành phố";
            dgv_ShowCuaHang.Columns[5].Name = "Quốc gia";
            foreach (var item in _icuaHangServices.GetCuaHang())
            {
                dgv_ShowCuaHang.Rows.Add(item.Id, item.MaCH, item.TenCH, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                CuaHang ch = new CuaHang()
                {
                    Id = Guid.NewGuid(),
                    MaCH = tb_Ma.Text,
                    TenCH = tb_Ten.Text,
                    DiaChi = tb_DiaChi.Text,
                    ThanhPho = tb_ThanhPho.Text,
                    QuocGia = tb_QuocGia.Text,
                };
                _icuaHangServices.AddCH(ch);
                MessageBox.Show("Thêm cửa hàng thành công");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
                
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var Chang = _icuaHangServices.GetCuaHang().FirstOrDefault(c => c.Id == _id);
            _CH.Id = Chang.Id;
            _CH.MaCH = tb_Ma.Text;
            _CH.TenCH = tb_Ten.Text;
            _CH.DiaChi = tb_DiaChi.Text;
            _CH.ThanhPho = tb_ThanhPho.Text;
            _CH.QuocGia = tb_QuocGia.Text;
            _icuaHangServices.UpdateCH(_CH);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var Chang = _icuaHangServices.GetCuaHang().FirstOrDefault(c => c.Id == _id);
            _icuaHangServices.DeleteCH(Chang);
            LoadData();
            MessageBox.Show("Xoá thành công");
        }

        private void dgv_ShowCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dgv_ShowCuaHang.Rows[e.RowIndex].Cells[0].Value.ToString());
            //var Chang = _icuaHangServices.GetCuaHang().FirstOrDefault(c => c.Id == _id);
            //tb_Ma.Text = Chang.MaCH.ToString();
            //tb_Ten.Text = Chang.TenCH.ToString();
            //tb_DiaChi.Text = Chang.DiaChi.ToString();
            //tb_ThanhPho.Text = Chang.ThanhPho.ToString();
            //tb_QuocGia.Text = Chang.QuocGia.ToString();
            tb_Ma.Text = dgv_ShowCuaHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_Ten.Text = dgv_ShowCuaHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_DiaChi.Text = dgv_ShowCuaHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_ThanhPho.Text = dgv_ShowCuaHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_QuocGia.Text = dgv_ShowCuaHang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
