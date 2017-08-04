using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Patates:Ekstralar
    {
        //patates sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public Patates(float fiyati)
        {
            Ad = "Patates";
            Fiyat = fiyati;
        }
    }
}
