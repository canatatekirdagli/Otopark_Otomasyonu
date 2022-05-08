using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class AdminEkle : Form
    {
        DatabaseConnection con = new DatabaseConnection();
        public AdminEkle()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            YeniAdmin(ad_soyad,kullanici_adi,sifre,this);
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show(this);
            Hide();
        }

        private void ad_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        public void YeniAdmin(TextBox ad_soyad, TextBox kullanici_adi, TextBox sifre, Form form)//Yeni Admin Ekleme
        {
            try
            {
                if (ad_soyad.Text == "" || kullanici_adi.Text == "" || sifre.Text == "")
                {
                    MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
                }
                else if (sifre.TextLength < 3)
                {
                    MessageBox.Show("Şifreniz minimum 3 karakterden oluşmalıdır!!");
                }
                else
                {
                   
                    con.SqlProcess("insert into giris values('" + kullanici_adi.Text + "','" + sifre.Text + "','" + ad_soyad.Text + "')");
                  
                    MessageBox.Show("Üye Eklendi!");
                    AnaSayfa anasayfa = new AnaSayfa();
                    anasayfa.Show();
                    form.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu kullanıcı adı kullanılmaktadır. Lütfen farklı kullanıcı adıyla deneyiniz.");
            }
        }
    }
}
