using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom15_DAL;

namespace Nhom15_BLL
{
    public class BLL_BANHMAN
    {

        private DAL_BANHMAN dAL_BANHMAN = new DAL_BANHMAN();
        public List<BanhMan> ListBanhMan()
        {
            return dAL_BANHMAN.listBanhMan();
        }
        public int SUA_BanhMan(BanhMan man)
        {
            int kq = 0;
            if (dAL_BANHMAN.TimMaBanhMan(man.MaBanh) == null)
            {
                kq = 0;
            }
            else
            {
                dAL_BANHMAN.SUA_BanhMan(man);
                kq = 1;
            }
            return kq;
        }
        public void deleteBanhMan(BanhMan man)
        {
            dAL_BANHMAN.deleteBanhMan(man);
        }
        public int them_BanhMan(BanhMan man)
        {
            int a = 0;
            if (dAL_BANHMAN.TimMaBanhMan(man.MaBanh) != null)
                a = 0;
            else
            {
                dAL_BANHMAN.them_BanhMan(man);
                a = 1;
            }
            return a;
        }


    }


}
