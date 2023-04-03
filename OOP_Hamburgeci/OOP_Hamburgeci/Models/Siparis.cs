using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgeci.Models
{
    internal class Siparis
    {
        //Verilen Sipariişlerin ve paralarının tutulduğu dictionary
        public static Dictionary<string,decimal> SiparisVeParaları=new Dictionary<string,decimal>();
        public static Dictionary<string,decimal> GeciciSiparisVeParaları=new Dictionary<string,decimal>();
        //Toplam Satış parasını tutan 
        public static decimal Ciro=0;
        //Toplam sipariş sayısı
        public static int SiparisSayisi = 0;
        //Ekstra Malzeme Geliri
        public static decimal EkstraMalzeme = 0;
        //Satılan ürün adeti
        public static int SatılanUrunAdeti = 0;

    }
}
