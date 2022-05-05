﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public class DatabaseConnection
    {
        public string connectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public DatabaseConnection()
        {
            connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=otopark_simulasyonu;Integrated Security = True";
            connection = new SqlConnection(connectionString);
          
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlDataReader DataReader(string query)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query,connection);
            var execute = cmd.ExecuteReader();
            
            return execute; 
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void SqlProcess(string query)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(query,connection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }
        //Kaynakça https://www.youtube.com/watch?v=KylvxtIiokg
        public void Login(string kullanici_adi,string sifre,Form form1)//Giriş Ekranı
        {
            command = new SqlCommand("Select * From giris where kullanici_adi='"+kullanici_adi+"'and sifre='"+sifre+"'",connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş başarılı!");
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                form1.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.");
            }
            connection.Close();
            connection.Dispose();
        }
        public void yeniAdmin(TextBox ad_soyad,TextBox kullanici_adi,TextBox sifre,Form form)//Yeni Admin Ekleme
        {
            try
            {
                if (ad_soyad.Text==""||kullanici_adi.Text==""||sifre.Text=="")
                {
                    MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
                }
                else if (sifre.TextLength<3)
                {
                    MessageBox.Show("Şifreniz minimum 3 karakterden oluşmalıdır!!");
                }
                else
                {
                    connection.Open();
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into giris values('" + kullanici_adi.Text + "','" + sifre.Text + "','" + ad_soyad.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
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
