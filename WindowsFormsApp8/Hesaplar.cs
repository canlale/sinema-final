using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Hesaplar
    {
        public int gozluksayisi;
        public int menusayisi;
        public int EkUcret;

        public void EkUcretHesapla()
        {
            EkUcret = (gozluksayisi * 6) + (menusayisi * 10);
        }
    }
}
