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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifre başarıyla değiştirildi!");
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show(this);
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar=new Ayarlar();
            ayarlar.Show(this);
            Hide();
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM giris", connection));
            while (reader.Read())
            {
                kullanici_adi.Items.Add(reader["kullanici_adi"]);
            }
            connection.CloseConnection();
        }
    }
}
