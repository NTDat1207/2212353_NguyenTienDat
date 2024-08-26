using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_BT3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }
        public NhanVien()
        {
            MaNV = "2212353";
            HoTen = "Nguyen Tien Dat";
            NgaySinh = new DateTime(2004, 07, 12);
            HeSoLuong = 10;
            HeSoPhuCap = 5;
        }
        public int TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return string.Format($"{MaNV}, {HoTen}, {NgaySinh.ToString("dd/MM/yyyy")}, {HeSoLuong}, {HeSoPhuCap}");
        }
    }
}
