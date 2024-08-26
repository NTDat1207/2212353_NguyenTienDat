using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_BT4
{
    internal class ChucNang
    {
        public static void ChaoHoi(string hoten, string gioitinh)
        {
            if (gioitinh == "Nam")
                MessageBox.Show("Chào Ông " + hoten, "Thông báo");
            else
                MessageBox.Show("Chào Bà " + hoten, "Thông báo");
        }
        public static int USCLN(int m, int n)
        {
            while (n != 0)
            {
                int temp = m % n;
                m = n;
                n = temp;
            }
            return m;
        }
    }
}
