using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Hamburgeci.Forms;

namespace OOP_Hamburgeci.Models
{
    internal class Fonksiyonlar
    {
        private static decimal _toplamtutar = 0;

        /// <summary>
        /// Dictioanry Koleksiyonuna Menu Ekle Methodu (Kontrol Yapıldı.)
        /// </summary>
        /// <param name="dic">Koleksiyon Adı</param>
        /// <param name="key">Eklenecek String Anahtar</param>
        /// <param name="value">Eklenecek Değer</param>
        public static void DictionaryeMenuEkle(Dictionary<string, decimal> dic, string key, decimal value)
        {
            if (key == string.Empty)
            {
                MessageBox.Show("Ekleme yapıcağınız menünün ismi olmalıdır");
            }
            else if (dic.Keys.Contains(key))
            {
                MessageBox.Show("Aynı isimde menü bulunmaktadır.");
            }
            else
            {
                dic.Add(key, value);
            }
        }

        /// <summary>
        /// Dictioanry Koleksiyonuna Malzeme Ekle Methodu (Kontrol Yapıldı.)
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void DictionaryeMalzemeEkle(Dictionary<string, decimal> dic, string key, decimal value)
        {
            if (key == string.Empty)
            {
                MessageBox.Show("Ekleme yapıcağınız malzemenin ismi olmalıdır");
            }
            else if (dic.Keys.Contains(key))
            {
                MessageBox.Show("Aynı isimde malzeme bulunmaktadır.");
            }
            else
            {
                dic.Add(key, value);
            }
        }

        /// <summary>
        /// Tutarı sürekli güncelleme methodu
        /// </summary>
        /// <param name="menu">Menü Fiyatı</param>
        /// <param name="boyut">Boyut Seçim Tutarı</param>
        /// <param name="malzeme">Malzeme Tutarı</param>
        /// <param name="adet">Menü adeti</param>
        /// <returns>Güncel tutarı döndürür</returns>
        public static decimal ToplamParaEsitle(decimal menu, decimal boyut, decimal malzeme, int adet)
        {
            _toplamtutar = (menu + boyut + malzeme) * adet;
            return _toplamtutar;
        }

        /// <summary>
        /// ToTitleCase ile girilen menü || malzeme adının düzenlenmesi
        /// </summary>
        /// <param name="oluşturulacakAd">Yenilenecek isim </param>
        /// <returns>Yenilenmiş isim</returns>
        public static string AdiDuzenle(string olusturulacakAd)
        {
            string duzenliAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(olusturulacakAd).Trim();
            return duzenliAd;
        }

        /// <summary>
        /// Seçili olan RadioButton bulunarak enum değeri getirildi.
        /// </summary>
        /// <param name="grp">RadioButtonların bulunduğu GroupBox</param>
        /// <param name="deger">Enum İsmi</param>
        /// <returns>Enum Değeri</returns>
        public static int RadioButtonDegeriEnum(GroupBox grp, int deger)
        {
            foreach (RadioButton item in grp.Controls)
            {
                if (item.Checked)
                {
                    deger = Convert.ToInt32(Enum.Parse(typeof(EnumC.Buyukluk), item.Text));
                }
            }
            return deger;
        }

        /// <summary>
        /// Seçili olan RadioButton bulunarak enum İsmi getirildi.
        /// </summary>
        /// <param name="grp">RadioButtonların bulunduğu GroupBox</param>
        /// <param name="deger">Enum Değeri</param>
        /// <returns>Enum İsmi</returns>
        public static string RadioButtonDegeriEnumİsmi(GroupBox grp, int deger)
        {
            string istenilen = string.Empty;
            foreach (RadioButton item in grp.Controls)
            {
                if (item.Checked)
                {
                    istenilen = Enum.ToObject(typeof(EnumC.Buyukluk), deger).ToString();
                }
            }
            return istenilen;
        }

        /// <summary>
        /// FlowLayoutPanel içerisinde gezerek seçili Checkbox'ın ismi ile Dictioanry'deki Malzemenin değerini döndürür.
        /// </summary>
        /// <param name="flypnl">CheckBoxların bulunduğu tool</param>
        /// <param name="deger">Dictioanry içerisindeki parası</param>
        /// <param name="dic">Malzeme Koleksiyonu</param>
        /// <returns>Seçili Sosun Parası</returns>
        public static decimal MalzemeFiyatiBelirle(FlowLayoutPanel flypnl, decimal deger, Dictionary<string, decimal> dic)
        {
            foreach (CheckBox item in flypnl.Controls)
            {
                foreach (var sosAdı in dic)
                {
                    if (item.Checked && sosAdı.Key == item.Text)
                    {
                        deger += sosAdı.Value;
                    }
                }
            }
            return deger;
        }

        /// <summary>
        /// FlowLayoutPanel içerisinde gezerek seçili Checkbox'ın ismi ile Dictioanry'deki Malzemenin İsimlerini döndürür.
        /// </summary>
        /// <param name="flypnl">CheckBoxların bulunduğu tool</param>
        /// <returns>Seçili Sosun İsimleri</returns>
        public static string SeciliMalzemeİsimleri(FlowLayoutPanel flp)
        {
            string secilenMalzemeİsimleri = string.Empty;
            foreach (CheckBox item in flp.Controls)
            {
                if (item.Checked)
                {
                    secilenMalzemeİsimleri += item.Text + ",";
                }
            }
            return secilenMalzemeİsimleri;
        }

        /// <summary>
        /// ComboBox içerisinde gezerek seçili Değerin ismi ile Dictioanry'deki Menulerin fiyatlarını döndürür.
        /// </summary>
        /// <param name="cmbx">Menu isimlerinin bulunduğu tool</param>
        /// <param name="dic">Menu Koleksiyonu</param>
        /// <returns>Seçili Menulerin Fiyatlarını</returns> 
        public static decimal MenuFiyatınıGetir(Dictionary<string, decimal> dic, ComboBox cmbx)
        {
            decimal MenuParası = 0;
            foreach (var isim in MenuC.MenuVeParaları)
            {
                if (cmbx.SelectedItem.ToString() == isim.Key)
                {
                    MenuParası = isim.Value;
                }
            }
            return MenuParası;
        }

        /// <summary>
        /// MenulerVeParaları Dictioanry'sinde olup checkBoxda olmayan Menuyu ekler.(Yeni eklenen Menuleri Ekler)
        /// </summary>
        /// <param name="cmbx">Menu isimlerinin  bulunduğu tool</param>
        /// <param name="dic">Menu Koleksiyonu</param>
        /// <returns>Yeni Eklenen Menuyu Ekler</returns>
        /// 
        public static void MenuİsmiYoksaEkle(Dictionary<string, decimal> dic, ComboBox cmbx)
        {
            foreach (var isim in MenuC.MenuVeParaları.Keys)
            {
                if (!(cmbx.Items.Contains(isim)))
                {
                    cmbx.Items.Add(isim);
                }
            }
        }

        /// <summary>
        /// Eklenen Yeni Malzeme için yeni bir checkBox'ı FlowLayoutPanel içerisine ekleme.
        /// </summary>
        /// <param name="flp">Malzemelerin Bulunduğu tool</param>
        public static void MalzemeChechBoxEkle(FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            foreach (var malzeme in Ekstra.MalzemeVeFiyatları)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = AdiDuzenle(malzeme.Key);
                flp.Controls.Add(checkBox);
            }
        }

        /// <summary>
        /// Dictionary içerisindeki bilgileri listbox'a ekleme
        /// </summary>
        /// <param name="listBox">Bilgilerin yazdırılması istenilen list</param>
        /// <param name="dic">Bilgilerin bulunduğu koleksiyon</param>
        public static void ListboxaEkle(ListBox listBox, Dictionary<string, decimal> dic)
        {
            foreach (var isim in dic.Keys)
            {
                if (!(listBox.Items.Contains(isim)))
                {
                listBox.Items.Add(isim);

                }
            }
        }

        /// <summary>
        /// Bir Koleksiyon içerisindeki Bilgileri ikinci koleksiyona aktarma
        /// </summary>
        /// <param name="gecici">Bilgilerin bulunduğpu koleksiyon</param>
        /// <param name="kalıcı">Bilgilerin Aktarılacağı koleksiyon</param>
        public static void DictionaryiAktarma(Dictionary<string, decimal> gecici, Dictionary<string, decimal> kalıcı)
        {
            foreach (var item in gecici)
            {
                kalıcı.Add(item.Key, item.Value);
            }
        }

        /// <summary>
        /// Toplam Satış fiyatı hesaplama methodu
        /// </summary>
        /// <returns>Toplam Para</returns>
        public static decimal CiroHesapla()
        {
            foreach (var item in Siparis.SiparisVeParaları)
            {
                Siparis.Ciro += item.Value;
            }
            return Siparis.Ciro;
        }

        /// <summary>
        /// Toplam Sipariş Adetini hesaplar
        /// </summary>
        /// <returns>Sipariş Adeti Döndürür</returns>
        public static int SiparisSayısıOgren()
        {
            return Siparis.SiparisVeParaları.Count();
        }

        /// <summary>
        /// Kullanıcı ile aradakş Dialog sağlar
        /// </summary>
        public static void SiparisTamamShowDialog()
        {
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutarı: ₺ {GeciciTutarHesapla()} \nSatın almayı tamamlamak ister misiniz?",
                "Sipariş Bilgisi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Fonksiyonlar.DictionaryiAktarma(Siparis.GeciciSiparisVeParaları, Siparis.SiparisVeParaları);
            }
            else
            {
                MessageBox.Show("İptal Edildi", "İptal Ekranı", MessageBoxButtons.OK);
                Siparis.SatılanUrunAdeti = 0;
                Siparis.EkstraMalzeme = 0;
                Form1.menuEkle.Hide();
            }
        }

        /// <summary>
        /// sipariş alınırken Sipariş Tutarlarını hesaplar
        /// </summary>
        /// <returns></returns>
        public static decimal GeciciTutarHesapla()
        {
            decimal tutar = 0;
            foreach (var item in Siparis.GeciciSiparisVeParaları.Values)
            {
                tutar += item;
            }
            return tutar;
        }


    }
}
