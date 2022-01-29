using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom15_DAL;

namespace Nhom15_BLL
{
    public class BLL_KHACHHANG
    {
        private DAL_KHACHHANG dAL_KHACHHANG = new DAL_KHACHHANG();
        public List<KhachHang> ListKhachHang()
        {
            return dAL_KHACHHANG.listKhachHang();
        }
        public int SUA_KhachHang(KhachHang kh)
        {
            int kq = 0;
            if (dAL_KHACHHANG.TimMaKhachHang(kh.MaKhachHang) == null)
            {
                kq = 0;
            }
            else
            {
                dAL_KHACHHANG.SUA_KhachHang(kh);
                kq = 1;
            }
            return kq;
        }
        public void deleteKhachHang(KhachHang kh)
        {
            dAL_KHACHHANG.deleteKhachHang(kh);
        }
        public int them_KhachHang(KhachHang kh)
        {
            int a = 0;
            if (dAL_KHACHHANG.TimMaKhachHang(kh.MaKhachHang) != null)
                a = 0;
            else
            {
                dAL_KHACHHANG.them_KhachHang(kh);
                a = 1;
            }
            return a;
        }
    }
}
