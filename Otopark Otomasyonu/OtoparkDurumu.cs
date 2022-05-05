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
    public partial class OtoparkDurumu : Form
    {
        public OtoparkDurumu()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            Hide();
        }

        private void OtoparkDurumu_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("Select * from otopark"));
            while (reader.Read())
            {
                if ((bool)reader["otopark_durumu"] == true)
                {
                  string a= reader["park_yeri"].ToString();
                  Button button = new Button();
                    if (button.Text==a)
                    {
                        _ = button.BackColor == Color.Red;
                    }

                }
            }
        }

        private void B15_Click(object sender, EventArgs e)
        {

        }
    }
}
