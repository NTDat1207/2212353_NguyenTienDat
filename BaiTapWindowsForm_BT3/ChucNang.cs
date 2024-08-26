using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_BT3
{
    internal class ChucNang
    {
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            int i = hoten.IndexOf(" ");
            s1 = hoten.Substring(0, i);
            s2 = hoten.Substring(i + 1);
        }
        public static bool ThuTu(int n1, int n2)
        {
            if (n2 == n1 + 1)
                return true;
            else
                return false;
        }
    }
}
