using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_BT2
{
    internal class ChucNang
    {
        public static void NoiChuoi(string a, string b, ref string s)
        {
            s = a + " " + b;
        }
        public static long GiaiThua(int n)
        {
            long kq = n;
            for (int i = 1; i < n; i++)
            {
                kq *= (n - i);
            }
            return kq;
        }
    }
}
