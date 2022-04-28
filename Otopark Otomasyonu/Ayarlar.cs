using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa(); 
            anaSayfa.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıEkle kullanıcıEkle = new KullanıcıEkle();
            kullanıcıEkle.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıSil kullanıcıSil=new KullanıcıSil();
            kullanıcıSil.Show(this);
            Hide();
        }
    }
}
