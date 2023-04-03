using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgeci.Models
{
    internal class EnumC
    {
        List<string> list = new List<string>(); 
        public enum Buyukluk
        {
            Kücük=1,
            Orta=2,
            Büyük=3
        }

    }
}
