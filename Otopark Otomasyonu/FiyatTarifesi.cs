using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu
{
    public class FiyatTarifesi
    {
        public int ToplamUcret { get; set; }
        public int Dakika { get; set; }
        public FiyatTarifesi(int dakika)
        {
            this.Dakika = dakika;
            
        }
        public int UcretHesapla()
        {
            if (0 < Dakika && Dakika <= 10)
            {
                return 5;
            }
            else if (10 < Dakika && Dakika <= 30  )
            {
                return 10;
            }
            else if (30 < Dakika && Dakika <= 60)
            {
                return 20;
            }
            else
            {
                int artanSure =Convert.ToInt32((Dakika - 60) /30);
                int result = artanSure * 5;

                
                return 20 + result;
            }
        }
    }
}
