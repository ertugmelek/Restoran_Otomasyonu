using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class KozdePatlican:Ekstralar
    {
        //közde patlıcan sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public KozdePatlican(float fiyat)
        {
            Ad="Közde Patlıcan";
            Fiyat = fiyat;
        }

    }
}
