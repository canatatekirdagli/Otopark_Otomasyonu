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
    }
}
