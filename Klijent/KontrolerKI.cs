using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;

        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null) komunikacija = new Komunikacija();
            return komunikacija.poveziSeNaServer();           
        }
    }
}
