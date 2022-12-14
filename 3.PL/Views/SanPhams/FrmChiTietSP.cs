using _2.BUS.Services.SanPhams;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.PL.Views.SanPhams
{
    public partial class FrmChiTietSP : Form
    {
        IChiTietSpServices _IChiTietSpSV;
        ISanPhamServices _ISanPhamSV;
        IDongSpServices _IDongSpSV;
        IKichCoServices _IKichCoSV;
        IMauSacServices _IMauSacSV;
        INSXServices _INSXSV;
        List<ViewChiTietSP> _lstviewChiTietSPs;
        private Guid _id;
        SaveFileDialog _saveFile = new SaveFileDialog();
        public string Avatar = "";
        public FrmChiTietSP()
        {
            InitializeComponent();
            _IChiTietSpSV = new ChiTietSpServices();
            _ISanPhamSV = new SanPhamServices();
            _IDongSpSV = new DongSpServices();
            _IKichCoSV = new KichCoServices();
            _IMauSacSV = new MauSacServices();
            _INSXSV = new NSXServices();
            _lstviewChiTietSPs = new List<ViewChiTietSP>();
            rdb_Con.Checked = true;
            LoadSanPham();
            LoadDongSP();
            LoadKichCo();
            LoadMauSac();
            LoadNSX();
            LoadDataChiTietSP();

        }
        private void LoadSanPham()
        {
            foreach (var x in _ISanPhamSV.GetAll())
            {
                cbb_TenSP_ChiTietSP.Items.Add(x.TenSp);
            }
        }
        private void LoadDongSP()
        {
            foreach (var x in _IDongSpSV.GetAll())
            {
                cbb_DongSP_ChiTietSP.Items.Add(x.TenDsp);
            }
        }
        private void LoadKichCo()
        {
            foreach (var x in _IKichCoSV.GetKichCo())
            {
                cbb_KichCo_ChiTietSP.Items.Add(x.TenKc);
            }
        }
        private void LoadMauSac()
        {
            foreach (var x in _IMauSacSV.GetAll())
            {
                cbb_MauSac_ChiTietSP.Items.Add(x.TenMs);
            }
        }
        private void LoadNSX()
        {
            foreach (var x in _INSXSV.GetNsx())
            {
                cbb_NSX_ChiTietSP.Items.Add(x.TenNsx);
            }
        }
        private void LoadDataChiTietSP()
        {
            int stt = 1;
            dtg_Show_ChiTietSP.ColumnCount = 13;
            dtg_Show_ChiTietSP.Columns[0].Name = "STT";
            dtg_Show_ChiTietSP.Columns[1].Name = "ID";
            dtg_Show_ChiTietSP.Columns[2].Name = "Tên Sản Phẩm";
            dtg_Show_ChiTietSP.Columns[3].Name = "Dòng Sản Phẩm";
            dtg_Show_ChiTietSP.Columns[4].Name = "Kích Cỡ";
            dtg_Show_ChiTietSP.Columns[5].Name = "Màu Sắc";
            dtg_Show_ChiTietSP.Columns[6].Name = "Nhà Sản Xuất";
            dtg_Show_ChiTietSP.Columns[7].Name = "Số Lượng Tồn";
            dtg_Show_ChiTietSP.Columns[8].Name = "Gía Nhập";
            dtg_Show_ChiTietSP.Columns[9].Name = "Gía Bán";
            dtg_Show_ChiTietSP.Columns[10].Name = "Mô Tả";
            dtg_Show_ChiTietSP.Columns[11].Name = "Trạng thái";
            dtg_Show_ChiTietSP.Columns[12].Name = "Ảnh";
            dtg_Show_ChiTietSP.Rows.Clear();
            _lstviewChiTietSPs = _IChiTietSpSV.GetViewChiTietSps();
            if (tb_ChiTietSP_TimKiem.Text != "" && !string.IsNullOrEmpty(tb_ChiTietSP_TimKiem.Text))
            {
                _lstviewChiTietSPs = _lstviewChiTietSPs.Where(p => p.TenSanPham.Contains(tb_ChiTietSP_TimKiem.Text) || p.tenDongSp.Contains(tb_ChiTietSP_TimKiem.Text) || p.tenKichCo.Contains(tb_ChiTietSP_TimKiem.Text) || p.tenMauSac.Contains(tb_ChiTietSP_TimKiem.Text) || p.TenNsx.Contains(tb_ChiTietSP_TimKiem.Text)).ToList();
            }
            foreach (var x in _lstviewChiTietSPs)
            {
                dtg_Show_ChiTietSP.Rows.Add(stt++, x.Id, x.TenSanPham, x.tenDongSp, x.tenKichCo, x.tenMauSac, x.TenNsx, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.MoTa, x.TinhTrang == 1 ? "Còn Hàng" : "Hết Hàng", x.Anh);
            }
        }
        private ViewChiTietSP GetData()
        {
            var Sp = _ISanPhamSV.GetAll().FirstOrDefault(c => c.TenSp == cbb_TenSP_ChiTietSP.Text);
            var Dsp = _IDongSpSV.GetAll().FirstOrDefault(c => c.TenDsp == cbb_DongSP_ChiTietSP.Text);
            var Kc = _IKichCoSV.GetKichCo().FirstOrDefault(c => c.TenKc == cbb_KichCo_ChiTietSP.Text);
            var ms = _IMauSacSV.GetAll().FirstOrDefault(c => c.TenMs == cbb_MauSac_ChiTietSP.Text);
            var nsx = _INSXSV.GetNsx().FirstOrDefault(c => c.TenNsx == cbb_NSX_ChiTietSP.Text);
            ViewChiTietSP CTSP = new ViewChiTietSP()
            {
                Id = Guid.NewGuid(),
                IdSp = Sp.Id,
                IdDongSp = Dsp.Id,
                IdKichCo = Kc.Id,
                IdMauSac = ms.Id,
                IdNsx = nsx.Id,
                MoTa = rtb_MoTa_ChiTietSP.Text,
                SoLuongTon = Convert.ToInt32(tb_SoLuongTon_ChiTietSP.Text),
                GiaBan = Convert.ToDecimal(tb_GiaBan_ChiTietSP.Text),
                GiaNhap = Convert.ToDecimal(tb_GiaNhap_ChiTietSP.Text),
                TinhTrang = rdb_Het.Checked ? 0 : 1,
                
            };
            return CTSP;
        }

        private void btn_CTSP_Them_Click(object sender, EventArgs e)
        {
            if (cbb_TenSP_ChiTietSP.Text == "" || cbb_DongSP_ChiTietSP.Text == "" || cbb_KichCo_ChiTietSP.Text == "" || cbb_MauSac_ChiTietSP.Text == "" || cbb_NSX_ChiTietSP.Text == "")
            {
                MessageBox.Show("Thuộc tính không được để trống");
            }
            if (Convert.ToDecimal(tb_GiaBan_ChiTietSP.Text) < Convert.ToDecimal(tb_GiaNhap_ChiTietSP.Text))
            {
                MessageBox.Show("Giá bán phải lớn hơn giá nhập");
            }
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    _IChiTietSpSV.addSanPhamChiTiet(GetData());
                    LoadDataChiTietSP();
                    Utilities.Utilities.ResetControlValues(this);
                }
                LoadDataChiTietSP();
            }
            
        }

        private void btn_CTSP_Sua_Click(object sender, EventArgs e)
        {
            if (cbb_TenSP_ChiTietSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để sửa", "Thông báo");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
                {
                    var temp = GetData();
                    temp.Id = _id;
                    _IChiTietSpSV.updateSanPhamChiTiet(temp);
                    LoadDataChiTietSP();
                    Utilities.Utilities.ResetControlValues(this);
                    
                }
                LoadDataChiTietSP();
            }
           
        }

        private void btn_CTSP_Xoa_Click(object sender, EventArgs e)
        {
            if (cbb_TenSP_ChiTietSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để xóa", "Thông báo");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
                {
                    _IChiTietSpSV.deleteSanPhamChiTiet(_id);
                    LoadDataChiTietSP();
                    Utilities.Utilities.ResetControlValues(this);
                }
                LoadDataChiTietSP();
            }
           
        }

        private void btn_CTSP_TimKiem_Click(object sender, EventArgs e)
        {
            LoadDataChiTietSP();
        }

        private void btn_CTSP_Reset_Click(object sender, EventArgs e)
        {
            Utilities.Utilities.ResetControlValues(this);
            cbb_TenSP_ChiTietSP.Text = "";
            cbb_MauSac_ChiTietSP.Text = "";
            cbb_KichCo_ChiTietSP.Text = "";
            cbb_DongSP_ChiTietSP.Text = "";
            cbb_NSX_ChiTietSP.Text = "";
            tb_SoLuongTon_ChiTietSP.Text = "";
            tb_GiaBan_ChiTietSP.Text = "";
            tb_GiaNhap_ChiTietSP.Text = "";
            rdb_Con.Checked = false;
            rdb_Het.Checked = false;
            rtb_MoTa_ChiTietSP.Text = "";

        }

        private void btn_CTSP_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_Show_ChiTietSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show_ChiTietSP.Rows[e.RowIndex];
                _id = Guid.Parse(dtg_Show_ChiTietSP.Rows[e.RowIndex].Cells[1].Value.ToString());
                var CTSP = _IChiTietSpSV.GetChiTietSPs().FirstOrDefault(p => p.Id == _id);

                cbb_TenSP_ChiTietSP.Text = _ISanPhamSV.GetAll().FirstOrDefault(p => p.Id == CTSP.IdSp).TenSp;
                cbb_DongSP_ChiTietSP.Text = _IDongSpSV.GetAll().FirstOrDefault(p => p.Id == CTSP.IdDongSp).TenDsp;
                cbb_KichCo_ChiTietSP.Text = _IKichCoSV.GetKichCo().FirstOrDefault(p => p.Id == CTSP.IdKichCo).TenKc;
                cbb_MauSac_ChiTietSP.Text = _IMauSacSV.GetAll().FirstOrDefault(p => p.Id == CTSP.IdMauSac).TenMs;
                cbb_NSX_ChiTietSP.Text = _INSXSV.GetNsx().FirstOrDefault(p => p.Id == CTSP.IdNsx).TenNsx;
                rtb_MoTa_ChiTietSP.Text = CTSP.MoTa;
                tb_SoLuongTon_ChiTietSP.Text = CTSP.SoLuongTon.ToString();
                tb_GiaBan_ChiTietSP.Text = CTSP.GiaBan.ToString();
                tb_GiaNhap_ChiTietSP.Text = CTSP.GiaNhap.ToString();
                
                if (CTSP.TinhTrang == 1)
                {
                    rdb_Con.Checked = true;
                    rdb_Het.Checked = false;
                }
                else
                {
                    rdb_Het.Checked = true;
                    rdb_Con.Checked = false;
                }
                ptb_CTSP_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
                if (CTSP.Anh != null && File.Exists(CTSP.Anh))
                {
                    ptb_CTSP_Anh.Image = Image.FromFile(CTSP.Anh);
                    ptb_CTSP_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
                    Avatar = CTSP.Anh;
                }
                else
                {
                    ptb_CTSP_Anh.Image = null;
                }
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (ptb_CTSP_Anh.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh ko?",
                    "...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        Avatar = op.FileName;
                        ptb_CTSP_Anh.Image = Image.FromFile(op.FileName);
                        ptb_CTSP_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
                        MessageBox.Show(op.FileName);
                    }
                }
            }
            if (ptb_CTSP_Anh.Image == null)
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Avatar = op.FileName;
                    ptb_CTSP_Anh.Image = Image.FromFile(op.FileName);
                    //ptb_CTSP_Anh.SizeMode = PictureBoxSizeMode.CenterImage;
                    MessageBox.Show(op.FileName);
                }

            }
        }

        //private void ptb_CTSP_Anh_DragDrop(object sender, DragEventArgs e)
        //{
        //    try
        //    {
        //        var data = e.Data.GetData(DataFormats.FileDrop);
        //        if (data != null)
        //        {
        //            var filename = data as string[];
        //            if (filename.Length > 0 && filename.Length < 512000)
        //            {
        //                ptb_CTSP_Anh.Image = Image.FromFile(filename[0]);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ptb_CTSP_Anh_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Copy;
        //}


    }
}

