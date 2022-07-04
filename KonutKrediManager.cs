using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediHesaplama
{
    internal class KonutKrediManager : IKrediler
    {
        private int _tutar, _vade;

        public string KrediAdi => "Konut Kredisi";

        public int Tutar
        {
            get { return _tutar; }
            set
            {
                _tutar = value;

                if (value > 20000000)
                {
                    _tutar = 20000000;
                    Console.WriteLine("max 20000000 tl kredi çekebilirisinz");
                }
                else if (value < 5000)
                {
                    _tutar = 5000;
                    Console.WriteLine("minimum 5000 tl kredi çekebilirsiniz");
                }
            }
        }

        public double FaizOrani => 1.98;

        public int Vade
        {
            get{ return _vade; }
            set
            {
                _vade = value;

                if (value>120)
                {
                    _vade = 120;
                    Console.WriteLine("En fazla 120 ay vadeli kredi çekilebilir.");
                }
                else if (value<12)
                {
                    _vade = 12;
                    Console.WriteLine("En az 12 ay vadeli kredi çekilebilir.");

                }
            }
        }
        public double FaizliTutar { get ; set; }
        public double KrediHesaplama()
        {
            Console.Write("çekmek istedinizi tutar: ");

            int tutar = int.Parse(Console.ReadLine());
            Console.Write("vade sürenizi giriniz: ");
            int vade = int.Parse(Console.ReadLine());
            this.Vade = vade;
            this.Tutar = tutar;
            this.FaizliTutar = this.Tutar+((this.Tutar * this.Vade * FaizOrani) / 100);
            return Math.Round(FaizliTutar, 2);


        }

        public void Aciklama()
        {
            Console.WriteLine("aylık ödeme tutarınız: " + Math.Round(this.FaizliTutar / this.Vade), 2);

            Console.WriteLine(Math.Round(FaizliTutar, 2));
        }

    }
}
