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

namespace OOP_Hamburgeci.Forms
{
    public partial class MalzemeGir : Form
    {
        public MalzemeGir()
        {
            InitializeComponent();
        }

        private void MalzemeGir_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.DictionaryeMalzemeEkle(Ekstra.MalzemeVeFiyatları,Fonksiyonlar.AdiDuzenle(txtMalzemeAdi.Text), nmrcupFiyat.Value);
            Siparis.EkstraMalzeme +=(int) nmrcupFiyat.Value;
        }

    }
}
