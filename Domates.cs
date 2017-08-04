using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Domates:Ekstralar
    {
        //domates sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public Domates(float fiyat)
        {
            Ad = "Domates";
            Fiyat = fiyat;
        }
    }
}
