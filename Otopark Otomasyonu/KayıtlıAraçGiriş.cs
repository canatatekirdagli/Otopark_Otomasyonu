using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class KayıtlıAraçGiriş : Form
    {

        public KayıtlıAraçGiriş()
        {
            InitializeComponent();
        }
      

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OtoparkDurumu otoparkDurumu = new OtoparkDurumu();
            otoparkDurumu.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Hide();
        }

        private void KayıtlıAraçGiriş_Load(object sender, EventArgs e)
        {
          
        }
    }
}
