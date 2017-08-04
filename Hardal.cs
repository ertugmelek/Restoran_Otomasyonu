using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Hardal:Ekstralar
    {
        //hardal sınıfında ekstralar sınıfından gelen ad ve parametre olarak aldığım fiyat değerlerini giriyorum
        public Hardal(float fiyat)
        {
            Ad = "Hardal";
            Fiyat = fiyat; 
        }
    }
}
