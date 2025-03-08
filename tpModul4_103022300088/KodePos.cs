using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_103022300088
{
    class KodePos
    {
        public enum Daerah 
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
        }
        public static int getKodePos(Daerah daerah)
        {
            int[] KodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return KodePos[(int)daerah];
        }
    }
}   
