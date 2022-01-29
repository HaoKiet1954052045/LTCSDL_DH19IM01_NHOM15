using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nhom15_DAL
{
    public class DAL_HOADON
    {
        DBQLBanhDataContext db;
        public DAL_HOADON()
        {
            db = new DBQLBanhDataContext();
        }
        public List<HoaDon> ListHoaDon()
        {
            List<HoaDon> hd = db.HoaDons.Select(s => s).ToList();
            return hd;
        }
        public string getMaHD()
        {
            return db.new_MaHoaDon().ToString();
        }
        public void them_HoaDon(HoaDon d)
        {
            db.them_HoaDon(d.MaKhachHang, d.MaNhanVien, d.MaBanhMan, d.SoLuongBanhMan, d.MaBanhNgot, d.SoLuongBanhNgot, d.MaBanhCookie, d.SoLuongBanhCookie);
        }
        public HoaDon Find_HoaDon(int MaHD)
        {
            return db.HoaDons.FirstOrDefault(s => s.MaHoaDon == MaHD);
        }
    }
}