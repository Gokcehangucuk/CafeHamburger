using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Hamburgeci.Models;

namespace OOP_Hamburgeci.Forms
{
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnYeniMenuKaydet_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.DictionaryeMenuEkle(MenuC.MenuVeParaları, Fonksiyonlar.AdiDuzenle(txtYeniMenu.Text), (decimal)nmrupYeniMenuFiyat.Value);
        }

    }
}
