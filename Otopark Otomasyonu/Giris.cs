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
    public partial class Giris1 : Form
    {
        public Giris1()
        {
            InitializeComponent();
        }
        DatabaseConnection connection = new DatabaseConnection();
        private void Giris_Load(object sender, EventArgs e)
        {
        
            
        }


        private void button10_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            if (kullanici_adi1.Text == "" || sifre1.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.");
            }
            else
            {
                string kullanici_adi = kullanici_adi1.Text;
                string sifre = sifre1.Text;
                connection.Login(kullanici_adi, sifre, this);              
            }
           

          
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                sifre1.UseSystemPasswordChar = false;
            }
            else
            {
                sifre1.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sifre1.UseSystemPasswordChar=true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
