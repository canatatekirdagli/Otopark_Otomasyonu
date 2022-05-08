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
    public partial class Hesap_kesim : Form
    {
        DatabaseConnection con = new DatabaseConnection();
        public Hesap_kesim()
        {
            InitializeComponent();
        }

        private void geri_don_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa=new AnaSayfa();
            anaSayfa.Show(this);
            Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void hesap_kesim_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = con.DataReader("SELECT * FROM cuzdan");
            if (reader == null)
            {
                kazanc.Text = "0 TL";
            }
            else
            {
                while (reader.Read())
                {
                    kazanc.Text = reader["toplam_kazanc"].ToString() + " TL";
                }
                con.CloseConnection();
            }
        }
    }
}
