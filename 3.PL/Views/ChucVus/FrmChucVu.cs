using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services.ChucVus;
using _1.DAL.Entities;

namespace _3.PL.Views.ChucVus
{
    public partial class FrmChucVu : Form
    {
        private IChucVuServices _ichucVuServices;
        ChucVu _chucVu;
        private Guid _id;
        public FrmChucVu()
        {
            InitializeComponent();
            _ichucVuServices = new ChucVuServices();
            _chucVu = new ChucVu();
            LoadData();
        }
        public void LoadData()
        {
            dgv_ShowCV.ColumnCount = 3;
            dgv_ShowCV.Rows.Clear();
            dgv_ShowCV.Columns[0].Name = "Id";
            dgv_ShowCV.Columns[0].Visible = false;
            dgv_ShowCV.Columns[1].Name = "Mã chức vụ";
            dgv_ShowCV.Columns[2].Name = "Tên chức vụ";
            foreach (var item in _ichucVuServices.GetAllChucVu())
            {
                dgv_ShowCV.Rows.Add(item.Id, item.MaCV, item.TenCV);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_MaCv.Text != "")
            {
                ChucVu cv = new ChucVu()
                {
                   Id = Guid.NewGuid(),
                   MaCV = tb_MaCv.Text,
                   TenCV = tb_TenCv.Text
               };
                _ichucVuServices.AddCV(cv);
                LoadData();
                MessageBox.Show("Thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var cv = _ichucVuServices.GetAllChucVu().FirstOrDefault(c => c.Id == _id);
            _chucVu.Id = cv.Id;
            _chucVu.MaCV = tb_MaCv.Text;
            _chucVu.TenCV = tb_TenCv.Text;
            _ichucVuServices.UpdateCV(cv);
            
            MessageBox.Show("Sửa thành công");
            LoadData();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var cv = _ichucVuServices.GetAllChucVu().FirstOrDefault(c => c.Id == _id);
            _ichucVuServices.DeleteCV(cv);
            LoadData();
            MessageBox.Show("Xoá thành công");
        }

        private void dgv_ShowCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dgv_ShowCV.Rows[e.RowIndex].Cells[0].Value.ToString()) ;
            tb_MaCv.Text = dgv_ShowCV.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_TenCv.Text = dgv_ShowCV.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
