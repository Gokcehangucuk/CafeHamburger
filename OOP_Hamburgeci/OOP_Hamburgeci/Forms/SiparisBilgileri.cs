﻿using System;
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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            Fonksiyonlar.ListboxaEkle(listBox1, Siparis.SiparisVeParaları);
            lblCiro.Text = Fonksiyonlar.CiroHesapla().ToString();
            lblSiparisSayısı.Text=Fonksiyonlar.SiparisSayısıOgren().ToString();
            lblMalzemeGelir.Text=Siparis.EkstraMalzeme.ToString();
            lblSatılanAdet.Text=Siparis.SatılanUrunAdeti.ToString();
        }
    }
}
