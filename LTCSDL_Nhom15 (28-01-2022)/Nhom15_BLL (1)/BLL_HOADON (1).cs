using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom15_DAL;

namespace Nhom15_BLL
{
    public class BLL_HOADON
    {
        DAL_HOADON dAL_HOADON;
        public BLL_HOADON()
        {
            dAL_HOADON = new DAL_HOADON();
        }
        public List<HoaDon> ListHoaDon()
        {
            List<HoaDon> hd = dAL_HOADON.ListHoaDon();
            return hd;
        }
        public string getMaHD()
        {
            return dAL_HOADON.getMaHD();
        }
        public int them_HoaDon(HoaDon d)
        {
            int kq = 0;
            if (dAL_HOADON.Find_HoaDon(d.MaHoaDon) == null)
            {
                kq = 1;
                dAL_HOADON.them_HoaDon(d);
                
            }
            return kq;
        }
    }
}
