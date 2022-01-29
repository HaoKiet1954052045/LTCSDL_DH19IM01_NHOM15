using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nhom15_DAL
{
    public class DAL_BANHCOOKIE
    {

        DBQLBanhDataContext db;
        public DAL_BANHCOOKIE()
        {
            db = new DBQLBanhDataContext();
        }
        public List<BanhCookie> ListBanhCookie()
        {
            List<BanhCookie> banhck = db.BanhCookies.Select(s => s).ToList();
            
            return banhck;
        }
        public void SUA_BanhCookie(BanhCookie ck)
        {
            db.sua_BanhCookie(ck.MaBanh, ck.TenBanh, ck.GiaTien);
        }
        public BanhCookie TimMaBanhCookie(int maBanhCK)
        {
            return db.BanhCookies.FirstOrDefault(s => s.MaBanh == maBanhCK);
        }
        public void deleteBanhCookie(BanhCookie ck)
        {
            db.xoa_BanhCookie(ck.MaBanh);
        }
        public void them_BanhCookie(BanhCookie ck)
        {
            db.them_BanhCookie(ck.TenBanh, ck.GiaTien);
        }
    }
}
