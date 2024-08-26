using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_BT2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            string chuoiA = txtChuoiA.Text;
            string chuoiB = txtChuoiB.Text;
            int n = int.Parse(txtSoN.Text);
            string kq1 = "";
            long kq2;
            if (rdNoiChuoi.Checked)
            {
                ChucNang.NoiChuoi(chuoiA, chuoiB, ref kq1);
                lblKetQua.Text = kq1;
            }
            else
            {
                kq2 = ChucNang.GiaiThua(n);
                lblKetQua.Text = kq2.ToString();
            }
                
        }
    }
}
