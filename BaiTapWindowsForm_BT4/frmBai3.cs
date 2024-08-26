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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string gioiTinh = cbbGioiTinh.Text;
            int SoM = int.Parse(txtSoM.Text);
            int SoN = int.Parse(txtSoN.Text);
            int kq = 0;
            if (rdChaoHoi.Checked)
                ChucNang.ChaoHoi(hoTen, gioiTinh);
            else
                kq = ChucNang.USCLN(SoM, SoN);
            lblKetQua.Text = kq.ToString();
        }
    }
}
