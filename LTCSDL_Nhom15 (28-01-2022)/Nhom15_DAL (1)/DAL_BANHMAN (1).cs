using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom15_DAL
{
    public class DAL_BANHMAN
    {
        DBQLBanhDataContext db;
        public DAL_BANHMAN()
        {
            db = new DBQLBanhDataContext();
        }
        public List<BanhMan> listBanhMan()
        {
            List<BanhMan> banhman = db.BanhMans.Select(s => s).ToList();
            return banhman;
        }
        public void SUA_BanhMan(BanhMan man)
        {
            db.sua_BanhMan(man.MaBanh, man.TenBanh, man.GiaTien);
        }
        public BanhMan TimMaBanhMan(int maBanhMan)
        {
            return db.BanhMans.FirstOrDefault(s => s.MaBanh == maBanhMan);

        }        
        public void deleteBanhMan(BanhMan man)
        {
            db.xoa_BanhMan(man.MaBanh);
        }
        public void them_BanhMan(BanhMan man)
        {
            db.them_BanhMan(man.TenBanh, man.GiaTien);
        }
        

    }
}
