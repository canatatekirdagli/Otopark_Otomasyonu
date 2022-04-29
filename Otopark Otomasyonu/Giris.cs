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
            if (kullanici_adi.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.");
            }
            else
            {
                SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM giris WHERE kullanici_adi = '{0}' AND sifre = '{1}'", kullanici_adi.Text, sifre.Text));
                
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
                sifre.UseSystemPasswordChar = false;
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sifre.UseSystemPasswordChar=true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        

        private void Giris_Enter(object sender, EventArgs e)
        {
            if (kullanici_adi.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.");
            }
            else if (kullanici_adi.Text == "admin" && sifre.Text == "12345")
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
