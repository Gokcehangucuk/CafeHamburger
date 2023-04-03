using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Hamburgeci.Forms;
using OOP_Hamburgeci.Models;

namespace OOP_Hamburgeci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SiparisOlustur siparisOlustur = new SiparisOlustur();
        public static SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
        public static MenuEkle menuEkle = new MenuEkle();
        public static MalzemeGir malzemeGir = new MalzemeGir();
        private void Form1_Load(object sender, EventArgs e)
        {

            siparisOlustur.MdiParent = this;
            siparisBilgileri.MdiParent = this;
            
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisBilgileri.Hide();
            siparisOlustur.Show();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisOlustur.Hide();
            siparisBilgileri.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuEkle.Owner = this;
            menuEkle.ShowDialog();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            malzemeGir.Owner = this;
            malzemeGir.ShowDialog();
        }

    }
}
