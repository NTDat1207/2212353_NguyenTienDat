using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_BT2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }   
        public ThietBi()
        {
            MaThietBi = "CPU01";
            TenThietBi = "CPU INTEL";
            NuocSanXuat = "Mỹ";
            DonGia = 50;
            SoLuong = 10;
        }
        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }
        public string HienThi()
        {
            return string.Format($"{MaThietBi}, {TenThietBi}, {NuocSanXuat}, {DonGia}, {SoLuong}");
        }
    }
}
