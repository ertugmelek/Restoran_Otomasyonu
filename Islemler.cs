using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    //adet ve tutara geçerli giriş yapılası kontrolünü sağlayan işlemler sınıfımı oluşturuyorum
    class Islemler
    {
        int _adet;
        float _tutar;
        public int Adet {
            get
            {
                return _adet;
            }
            set
            {
                if (_adet <= 0)
                    throw new Exception("Hata!");
                else
                    _adet = value;
            }
            }
        public float Tutar
        {
            get
            {
                return _tutar;
            }
            set
            {
                if (_tutar <= 0)
                    throw new Exception("Hata!");
                else
                    _tutar = value;
            }
        }
    }
}
