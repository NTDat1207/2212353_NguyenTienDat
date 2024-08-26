using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_BT3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            string chuoi = txtChuoi.Text;
            int n1 = int.Parse(txtSoN1.Text);
            int n2 = int.Parse(txtSoN2.Text);
            string str1 = "";
            string str2 = "";
            bool kq;
            if (rdTachChuoi.Checked)
            {
                ChucNang.TachChuoi(chuoi, ref str1, ref str2);
                lblKetQua.Text = "Họ: " + str1 + "\nTên: " + str2;
            }
            else
            {
                kq = ChucNang.ThuTu(n1, n2);
                lblKetQua.Text = (kq == true) ? "Đúng" : "Sai";
            }
        }
    }
}
