using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Tursu:Ekstralar
    {
        //turşu sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public Tursu(float fiyat)
        {
            Ad = "Turşu";
            Fiyat = fiyat;
        }
    }
}
