using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom15_DAL
{
    public class DAL_KHACHHANG
    {
        DBQLBanhDataContext db;
        public DAL_KHACHHANG()
        {
            db = new DBQLBanhDataContext();
        }
        public List<KhachHang> listKhachHang()
        {
            List<KhachHang> kh = db.KhachHangs.Select(s => s).ToList();
            return kh;

        }
        public void SUA_KhachHang(KhachHang kh)
        {
            db.sua_KhachHang(kh.MaKhachHang, kh.HoTen, kh.NgaySinh, kh.SoDienThoai, kh.GioiTinh, kh.DiaChi);
        }
        public KhachHang TimMaKhachHang(int maKhachHang)
        {
            return db.KhachHangs.FirstOrDefault(s => s.MaKhachHang == maKhachHang);
        }
        public void deleteKhachHang(KhachHang kh)
        {
            db.xoa_KhachHang(kh.MaKhachHang);
        }
        public void them_KhachHang(KhachHang kh)
        {
            db.them_KhachHang(kh.HoTen, kh.NgaySinh, kh.SoDienThoai, kh.GioiTinh, kh.DiaChi);
        }


    }
}
