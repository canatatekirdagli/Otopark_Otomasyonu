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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tarih_saat.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtlıAraçGiriş kayıtlıAraçGiriş = new KayıtlıAraçGiriş();
            kayıtlıAraçGiriş.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanıcı_Kaydı kullanıcıKaydi=new Kullanıcı_Kaydı();   
            kullanıcıKaydi.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OtoparkDurumu otoparkDurumu = new OtoparkDurumu();
            otoparkDurumu.Show(this);
            Hide();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araç_Çıkışcs aracCikis=new Araç_Çıkışcs();
            aracCikis.Show(this);
            Hide();
        }

      

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           KayıtlıKullanıcıSil kayitlikullanicisil=new KayıtlıKullanıcıSil();
            kayitlikullanicisil.Show(this);
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar=new Ayarlar();
            ayarlar.Show(this);
            Hide();
        }

        private void oturum_kapat_Click(object sender, EventArgs e)
        {
            Giris1 giris1 = new Giris1();
            giris1.Show(this);
            Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Hesap_kesim hesap_Kesim = new Hesap_kesim();
            hesap_Kesim.Show(this);
            Hide();
        }
    }
}
