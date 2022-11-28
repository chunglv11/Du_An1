using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class _Main : Form
    {
        public _Main()
        {
            InitializeComponent();
            Load_Btn();
        }
        public void Load_Btn()
        {
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.FlatAppearance.BorderSize = 0;
        }
    }
}
