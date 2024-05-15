using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefericoSanBernardo
{
    internal class Seeder
    {
        static public int seed()
        {
            Random rand = new Random();
            return rand.Next(10000, 20000);
        }
    }
}
