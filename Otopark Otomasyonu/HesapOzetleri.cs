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
    public partial class hesap_kesim : Form
    {
        public hesap_kesim()
        {
            InitializeComponent();
        }

        private void geri_don_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa=new AnaSayfa();
            anaSayfa.Show(this);
            Hide();
        }
    }
}
