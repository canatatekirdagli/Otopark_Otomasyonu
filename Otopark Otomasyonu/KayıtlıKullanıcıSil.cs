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
    public partial class KayıtlıKullanıcıSil : Form
    {
        public KayıtlıKullanıcıSil()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa=new AnaSayfa();
            anaSayfa.Show(this);
            Hide();
        }

        private void kayitli_kullanici_sil_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            try
            {
                if (tc.TextLength < 11 || tc.TextLength > 11)
                {
                    MessageBox.Show("Lütfen 11 haneli TC Kimlik numaranızı giriniz!!");
                }
                else
                {
                    SqlDataReader reader = connection.DataReader("select  * from musteri where tc_kimlik_no='" + tc.Text + "'");
                    DialogResult sonuc;
                    sonuc = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Kullanıcıyı sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (sonuc == DialogResult.No)
                    {
                    }
                    if (sonuc == DialogResult.Yes)
                    {
                        connection.CloseConnection();
                        connection.SqlProcess("DELETE from musteri where tc_kimlik_no='" + tc.Text + "'");
                        MessageBox.Show("Müşteri silindi!");
                        AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show(this);
                        Hide();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}
