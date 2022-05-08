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
    public partial class OtoparkDurumu : Form
    {
        DatabaseConnection con = new DatabaseConnection();
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
            foreach (var item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    SqlDataReader reader = con.DataReader(string.Format("SELECT * FROM otopark WHERE park_yeri = '{0}' AND otopark_durumu = 'TRUE'",btn.Text.ToLower()));
                    if (reader.HasRows)
                    {
                        btn.BackColor = Color.Red;
                    }
                }
                con.CloseConnection();
            }
         
        }

        private void B15_Click(object sender, EventArgs e)
        {

        }
    }
}
