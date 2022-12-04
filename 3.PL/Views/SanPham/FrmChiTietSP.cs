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

namespace _3.PL.Views.SanPham
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
            cbx_Con.Checked = true;
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
            dtg_Show_ChiTietSP.ColumnCount = 12;
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
            dtg_Show_ChiTietSP.Rows.Clear();
            _lstviewChiTietSPs = _IChiTietSpSV.GetViewChiTietSps();
            if (tbt_TimKiem_ChiTietSP.Text != "" && !string.IsNullOrEmpty(tbt_TimKiem_ChiTietSP.Text))
            {
                _lstviewChiTietSPs = _lstviewChiTietSPs.Where(p => p.TenSanPham.Contains(tb_ChiTietSP_TimKiem.Text) || p.tenDongSp.Contains(tb_ChiTietSP_TimKiem.Text) || p.tenKichCo.Contains(tb_ChiTietSP_TimKiem.Text) || p.tenMauSac.Contains(tb_ChiTietSP_TimKiem.Text) || p.TenNsx.Contains(tb_ChiTietSP_TimKiem.Text)).ToList();
            }
            foreach (var x in _lstviewChiTietSPs)
            {
                dtg_Show_ChiTietSP.Rows.Add(stt++, x.Id, x.TenSanPham, x.tenDongSp, x.tenKichCo, x.tenMauSac, x.TenNsx, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.MoTa, x.TinhTrang);
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
                TinhTrang = cbx_Het.Checked ? 0 : 1,
            };
            return CTSP;
        }

        private void btn_ChiTietSP_Them_Click(object sender, EventArgs e)
        {
            _IChiTietSpSV.addSanPhamChiTiet(GetData());
            LoadDataChiTietSP();
            Utilities.Utilities.ResetControlValues(this);
        }

        private void btn_ChiTietSP_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            _IChiTietSpSV.updateSanPhamChiTiet(temp);
            LoadDataChiTietSP();
            Utilities.Utilities.ResetControlValues(this);
        }

        private void btn_ChiTietSP_Xoa_Click(object sender, EventArgs e)
        {
            _IChiTietSpSV.deleteSanPhamChiTiet(_id);
            LoadDataChiTietSP();
            Utilities.Utilities.ResetControlValues(this);
        }

        private void btn_ShowChiTietSP_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChiTietSP_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbt_TimKiem_ChiTietSP_Click(object sender, EventArgs e)
        {
            LoadDataChiTietSP();
        }

        private void dtg_Show_ChiTietSP_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    cbx_Con.Checked = true;
                    cbx_Het.Checked = false;
                }
                else
                {
                    cbx_Het.Checked = true;
                    cbx_Con.Checked = false;
                }
            }
        }
    }
}
