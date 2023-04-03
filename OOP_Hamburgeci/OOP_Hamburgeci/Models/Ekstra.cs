using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgeci.Models
{
    internal class Ekstra
    {
        //Ekstra girilen malzeme ve fiyatlarını tutan dictionary.
        public static Dictionary<string,decimal> MalzemeVeFiyatları= new Dictionary<string,decimal>();



         static Ekstra()
        {
            MalzemeVeFiyatları.Add("Ketçap", 1.75m);
            MalzemeVeFiyatları.Add("Mayonez", 1.75m);
            MalzemeVeFiyatları.Add("Hardal", 1.75m);
            MalzemeVeFiyatları.Add("BBQ", 1.75m);
            MalzemeVeFiyatları.Add("Ranch", 1.75m);
            MalzemeVeFiyatları.Add("Buffalo", 1.75m);
        }

    }
}
