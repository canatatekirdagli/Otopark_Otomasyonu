﻿using System;
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
    public partial class KullanıcıEkle : Form
    {
        public KullanıcıEkle()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            connection.yeniKullanici(ad_soyad,kullanici_adi,sifre);
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show(this);
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show(this);
            Hide();
        }
    }
}
