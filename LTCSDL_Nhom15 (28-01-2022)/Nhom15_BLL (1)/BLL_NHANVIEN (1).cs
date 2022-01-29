using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom15_DAL;

namespace Nhom15_BLL
{
    public class BLL_NHANVIEN
    {
        private DAL_NHANVIEN dAL_NHANVIEN = new DAL_NHANVIEN();
        public bool KiemTraDN(string TenTK, string MK)
        {
            return dAL_NHANVIEN.KiemTraDN(TenTK, MK);
        }
        
        public List<NhanVien> ListNhanVien()
        {
            return dAL_NHANVIEN.listNhanVien();
        }
        public int SUA_NhanVien(NhanVien nv)
        {
            int kq = 0;
            if (dAL_NHANVIEN.TimMaNhanVien(nv.MaNhanVien) == null)
            {
                kq = 0;
            }
            else
            {
                dAL_NHANVIEN.SUA_NhanVien(nv);
                kq = 1;
            }
            return kq;
        }
        public void deleteNhanVien(NhanVien nv)
        {
            dAL_NHANVIEN.deleteNhanVien(nv);
        }
        public int them_NhanVien(NhanVien nv)
        {
            int a = 0;
            if (dAL_NHANVIEN.TimMaNhanVien(nv.MaNhanVien) != null)
                a = 0;
            else
            {
                dAL_NHANVIEN.them_NhanVien(nv);
                a = 1;
            }
            return a;
        }
        public bool KiemTraTkTonTai(string tk)
        {
            return dAL_NHANVIEN.KiemTraTKTonTai(tk);
        }
    }

}
