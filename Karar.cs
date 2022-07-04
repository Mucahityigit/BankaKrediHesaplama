using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediHesaplama
{
    class Karar
    {
        public void KrediCek(IKrediler krediAdi)
        {
            
            Console.WriteLine("kredi sonucunuz hesaplandı geri ödenecek tutar:  "+krediAdi.KrediHesaplama());//tasitkredisi
            krediAdi.Aciklama();
            
        }

    }
}
