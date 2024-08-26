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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int kq = 0;
            if (rdTongN.Checked)
            {
                for (int i = 1; i <= n; i++)
                {
                    kq += i;
                }
            }
            else
            {
                kq = n;
                for (int i = 1;i < n; i++)
                {
                    kq *= (n - i);
                }
            }
            lblKetQua.Text = kq.ToString();
        }
    }
}
