using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekBurada
{
    class Siparis
    {
        int _adet;
        public int Adet
        {
            get
            {
                return _adet;
            }
            set
            {
                if (_adet > 0)
                {
                    _adet = value;
                }
                else
                {
                    throw new Exception("Adet 0 dan küçük olmamalı!");

                }
            }
            
        }
    }
}
