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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        DatabaseConnection connection = new DatabaseConnection();
        private void Giris_Load(object sender, EventArgs e)
        {
            //deneme
            
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.");
            }
            else
            {
                SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM giris WHERE kullanici_adi = '{0}' AND sifre = '{1}'", textBox1.Text, textBox2.Text));
                
                    if(reader.HasRows == true)
                    {
                        AnaSayfa anasayfa = new AnaSayfa();
                        anasayfa.Show();
                        Hide();
                    //ASas
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.");
                    }
                //asdasd
              connection.CloseConnection();
              
            }
           

          
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar=true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        

        private void Giris_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}