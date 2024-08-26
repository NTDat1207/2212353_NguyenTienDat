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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            float diemLT = float.Parse(txtDiemLT.Text);
            float diemTH = float.Parse(txtDiemTH.Text);
            float diemTB = (diemLT + diemTH) / 2;
            if (diemLT < 5 || diemTH < 5)
                lblKetQuaXL.Text = "Yếu";
            else if (diemTB < 7)
                lblKetQuaXL.Text = "Trung bình";
            else if (diemTB >= 7 && diemTB < 8)
                lblKetQuaXL.Text = "Khá";
            else if (diemTB >= 8 && diemTB < 9)
                lblKetQuaXL.Text = "Giỏi";
            else
                lblKetQuaXL.Text = "Xuất xắc";
        }
    }
}
