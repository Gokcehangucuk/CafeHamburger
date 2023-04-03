using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Hamburgeci.Models;
using static System.Net.WebRequestMethods;

namespace OOP_Hamburgeci.Forms
{
    public partial class SiparisOlustur : Form
    {
        private decimal MenuFiyatı=0;
        private int BoyutFiyatı=0;
        private decimal MalzemeFiyatı = 0;
        private int Adet = 1;
        private decimal SiparisTutarı = 0;
        private string SiparisKey=string.Empty;
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            FormBorderStyle= FormBorderStyle.None;
            this.Dock= DockStyle.Fill;
            Fonksiyonlar.MalzemeChechBoxEkle(flypnlMalzeme);
            foreach (CheckBox item in flypnlMalzeme.Controls)
            {
                item.CheckedChanged += MalzemeSecimVeParaları;
            }
        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            SiparisKey = $"{cmbMenu.Text} x {nmrupAdet.Value.ToString()} Adet,{Fonksiyonlar.RadioButtonDegeriEnumİsmi(grpbxBoyut, BoyutFiyatı)} Boy,({Fonksiyonlar.SeciliMalzemeİsimleri(flypnlMalzeme)})";
            SiparisTutarı = Convert.ToDecimal(lblTutar.Text);
            Fonksiyonlar.DictionaryeMenuEkle(Siparis.GeciciSiparisVeParaları, SiparisKey, SiparisTutarı);
            Fonksiyonlar.ListboxaEkle(listBox1,Siparis.GeciciSiparisVeParaları);
            Siparis.SatılanUrunAdeti += (int)nmrupAdet.Value;
            SiparisTutarı = 0;
            SiparisKey = string.Empty;
        }
        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.SiparisTamamShowDialog();
            Siparis.GeciciSiparisVeParaları.Clear();
            listBox1.Items.Clear();
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuFiyatı = Fonksiyonlar.MenuFiyatınıGetir(MenuC.MenuVeParaları, cmbMenu);
            lblTutar.Text = Fonksiyonlar.ToplamParaEsitle(MenuFiyatı, BoyutFiyatı, MalzemeFiyatı, Adet).ToString();
        }

        private void cmbMenu_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.MenuİsmiYoksaEkle(MenuC.MenuVeParaları, cmbMenu);
            lblTutar.Text = Fonksiyonlar.ToplamParaEsitle(MenuFiyatı, BoyutFiyatı, MalzemeFiyatı, Adet).ToString();
        }

        public void BoyutSecimVeParaları(object sender, EventArgs e)
        {
            BoyutFiyatı = Fonksiyonlar.RadioButtonDegeriEnum(grpbxBoyut, BoyutFiyatı);
            lblTutar.Text = Fonksiyonlar.ToplamParaEsitle(MenuFiyatı, BoyutFiyatı, MalzemeFiyatı, Adet).ToString();
        }
        
        private  void MalzemeSecimVeParaları(object sender, EventArgs e)
        {
            MalzemeFiyatı = 0;
            MalzemeFiyatı = Fonksiyonlar.MalzemeFiyatiBelirle(flypnlMalzeme, MalzemeFiyatı, Ekstra.MalzemeVeFiyatları);
            lblTutar.Text = Fonksiyonlar.ToplamParaEsitle(MenuFiyatı, BoyutFiyatı, MalzemeFiyatı, Adet).ToString();
        }

        private void nmrupAdet_ValueChanged(object sender, EventArgs e)
        {
            Adet =(int)nmrupAdet.Value;
            lblTutar.Text = Fonksiyonlar.ToplamParaEsitle(MenuFiyatı, BoyutFiyatı, MalzemeFiyatı, Adet).ToString();
        }

        private void btnMalzemeYenile_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.MalzemeChechBoxEkle(flypnlMalzeme);
            foreach (CheckBox item in flypnlMalzeme.Controls)
            {
                item.CheckedChanged += MalzemeSecimVeParaları;
            }
        }
    }
}
