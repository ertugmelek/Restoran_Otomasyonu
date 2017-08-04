using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Barbeku:Ekstralar
    {
        //barbekü sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public Barbeku(float fiyat)
        {
            Ad = "Barbekü";
            Fiyat =fiyat ;
        }
    }
}
