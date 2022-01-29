using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom15_DAL
{
    public class DAL_BANHNGOT
    {

        DBQLBanhDataContext db;
        public DAL_BANHNGOT()
        {
            db = new DBQLBanhDataContext();
        }
        public List<BanhNgot> ListBanhNgot()
        {
            List<BanhNgot> banhngot = db.BanhNgots.Select(s => s).ToList();
            return banhngot;
        }
        public void SUA_BanhNgot(BanhNgot ngot)
        {
            db.sua_BanhNgot(ngot.MaBanh, ngot.TenBanh, ngot.GiaTien);
        }
        public BanhNgot TimMaBanhNgot(int maBanhNgot)
        {
            return db.BanhNgots.FirstOrDefault(s => s.MaBanh == maBanhNgot);
            
        }       
        public void XOA_BanhNgot(BanhNgot ngot)
        {
            db.xoa_BanhNgot(ngot.MaBanh);
        }
        public void them_BanhNgot(BanhNgot ngot)
        {
            db.them_BanhNgot(ngot.TenBanh, ngot.GiaTien);
        }
    }
}
