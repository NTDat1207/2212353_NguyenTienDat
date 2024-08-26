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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            float soThu1 = float.Parse(txtSoThu1.Text);
            float soThu2 = float.Parse(txtSoThu2.Text);
            float kq = 0;
            if (rdCong.Checked)
                kq = soThu1 + soThu2;
            if (rdTru.Checked)
                kq = soThu1 - soThu2;
            if (rdNhan.Checked)
                kq = soThu1 * soThu2;
            if (rdChia.Checked)
                kq = soThu1 / soThu2;
            lblKetQua.Text = kq.ToString();
        }
    }
}
