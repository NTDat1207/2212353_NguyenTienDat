using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_BT4
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "0001";
            sp.TenSanPham = "Sữa";
            sp.LoaiSanPham = "Đồ uống";
            sp.NgaySanXuat = new DateTime(2024, 09, 01);
            lblThongBao.Text = sp.HienThi();
            lblNamHetHan.Text = sp.NamHetHan().ToString();
        }
    }
}
