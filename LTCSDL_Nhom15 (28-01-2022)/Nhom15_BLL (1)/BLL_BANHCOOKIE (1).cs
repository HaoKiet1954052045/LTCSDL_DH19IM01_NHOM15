using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom15_DAL;

namespace Nhom15_BLL
{

    public class BLL_BANHCOOKIE
    {
        DAL_BANHCOOKIE dAL_BANHCOOKIE;
        public BLL_BANHCOOKIE()
        {
            dAL_BANHCOOKIE = new DAL_BANHCOOKIE();
        }
        public List<BanhCookie> ListBanhCookie()
        {
            return dAL_BANHCOOKIE.ListBanhCookie();
        }
        public int SUA_BanhCookie(BanhCookie ck)
        {
            int a = 0;
            if (dAL_BANHCOOKIE.TimMaBanhCookie(ck.MaBanh) == null)
            {
                a = 0;
            }
            else
            {
                dAL_BANHCOOKIE.SUA_BanhCookie(ck);
                a = 1;
            }
            return a;

            
        }
        public void deleteBanhCookie(BanhCookie ck)
        {
            dAL_BANHCOOKIE.deleteBanhCookie(ck);

        }
        public int them_BanhCookie(BanhCookie ck)
        {
            int a = 0;
            if (dAL_BANHCOOKIE.TimMaBanhCookie(ck.MaBanh) != null)
                a = 0;
            else
            {
                dAL_BANHCOOKIE.them_BanhCookie(ck);
                a = 1;
            }
            return a;
        }
    }


}
