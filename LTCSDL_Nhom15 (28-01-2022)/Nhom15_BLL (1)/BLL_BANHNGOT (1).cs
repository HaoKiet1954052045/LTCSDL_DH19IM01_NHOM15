using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom15_DAL;

namespace Nhom15_BLL
{
    public class BLL_BANHNGOT
    {
        DAL_BANHNGOT dAL_BANHNGOT;
        public BLL_BANHNGOT()
        {
            dAL_BANHNGOT = new DAL_BANHNGOT();
        }
        public List<BanhNgot> ListBanhNgot()
        {
            return dAL_BANHNGOT.ListBanhNgot();
        }
        public int SUA_BanhNgot(BanhNgot ngot)
        {
            int kq = 0;
            if (dAL_BANHNGOT.TimMaBanhNgot(ngot.MaBanh) == null)
            {
                kq = 0;
            }
            else
            {
                dAL_BANHNGOT.SUA_BanhNgot(ngot);
                kq = 1;
            }
            return kq;


        }
        public void deleteBanhNgot(BanhNgot ngot)
        {
            dAL_BANHNGOT.XOA_BanhNgot(ngot);
        }
        public int them_BanhNgot(BanhNgot ngot)
        {
            int a = 0;
            if (dAL_BANHNGOT.TimMaBanhNgot(ngot.MaBanh) != null)
                a = 0;
            else
            {
                dAL_BANHNGOT.them_BanhNgot(ngot);
                a = 1;
            }
            return a;
        }
    }
}
