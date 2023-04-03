using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgeci.Models
{
    internal class MenuC
    {
        //Menu isimlerinin ve paralarının tutulduğu para
        public static Dictionary<string, decimal> MenuVeParaları = new Dictionary<string, decimal>();
        
       

        //Menuler listesine direk olması gereken menulerin eklenmesi yapıldı.
         static MenuC()
        {
            MenuVeParaları.Add("Big King Menü", 87);
            MenuVeParaları.Add("Double King Chicken Menü", 77);
            MenuVeParaları.Add("Steakhouse Menü", 104);
            MenuVeParaları.Add("Whooper Menü", 89);
            MenuVeParaları.Add("Whooper Jr.Menü", 66);
            MenuVeParaları.Add("Chicken Royal Menü", 70);
        }
    }
}
