using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_103022300088
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kelurahan    Kode Pos");
            Console.WriteLine(" ");

            foreach (KodePos.Daerah daerah in Enum.GetValues(typeof(KodePos.Daerah)))
            {
                string namaDaerah = daerah.ToString();
                Console.WriteLine($"{namaDaerah,-12} {KodePos.getKodePos(daerah)}");
            }
        }
    }
}
