using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom15_DAL
{
    public class DAL_NHANVIEN
    {
        DBQLBanhDataContext db;
        public DAL_NHANVIEN()
        {
            db = new DBQLBanhDataContext();
        }
        public List<NhanVien> listNhanVien()
        {
            List<NhanVien> nv = db.NhanViens.Select(s => s).ToList();
            return nv;
        }
        public bool KiemTraDN(string TenTK, string MK)
        {
            bool kq = false;
            NhanVien t = db.NhanViens.FirstOrDefault(s => s.TenDangNhap == TenTK && s.MatKhau == MK);
            if (t != null)
                kq = true;
            return kq;
        }    
        
        public void deleteNhanVien(NhanVien nv)
        {
            db.xoa_NhanVien(nv.MaNhanVien);
        }
        public void SUA_NhanVien(NhanVien nv)
        {
            db.sua_NhanVien(nv.MaNhanVien, nv.HoTen,nv.NgaySinh,nv.SoDienThoai, nv.GioiTinh, nv.DiaChi, nv.ChucVu, nv.TenDangNhap, nv.MatKhau);
        }
        public NhanVien TimMaNhanVien(int maNhanVien)
        {
            return db.NhanViens.FirstOrDefault(s => s.MaNhanVien == maNhanVien);
        }
        public void them_NhanVien(NhanVien nv)
        {
            db.them_NhanVien(nv.HoTen, nv.NgaySinh, nv.SoDienThoai, nv.GioiTinh, nv.DiaChi,
                nv.ChucVu, nv.TenDangNhap, nv.MatKhau);
        }
        public bool KiemTraTKTonTai(string tk)
        {
            bool kq = false;
            NhanVien nv = db.NhanViens.FirstOrDefault(s => s.TenDangNhap == tk);
            if (nv != null)
                kq = true;
            return kq;
        }
    }
}
