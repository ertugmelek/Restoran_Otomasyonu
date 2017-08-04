using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Salatalik:Ekstralar
    {
        //salatalık sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public Salatalik(float fiyat)
        {
            Ad = "Salatalık";
            Fiyat = fiyat;
        }
    }
}
