using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKrediHesaplama
{
    internal class IhtiyacKredisiManager : IKrediler
    {
        public string KrediAdi => "Ihtiyac Kredisi";

        public double FaizOrani
        {
            get
            {
                return 1.5;
            }

        }
        private int _vade;
        public int Vade
        {
            get { return _vade; }
            set
            {
                if (value > 36)//max 36 ay vade
                {
                    _vade = 36;

                }
                else if (value <= 0)
                {
                    _vade = 3;//min 3 ay vade
                }
                else
                {
                    _vade = value;
                }


            }
        }
        private int _tutar;
        public int Tutar
        {
            get { return _tutar; }
            set
            {
                if (value<=950)
                {
                    _tutar = 950;
                    
                    Console.WriteLine("En az 950 TL kredi çekebilirsiniz");
                }
                else if(value> 1000000)
                {
                    _tutar = 1000000;
                    Console.WriteLine("En fazla 1.000.000 TL kredi çekebilirsiniz");
                }
                else
                {
                    _tutar = value;
                }
            }
        }

        public double FaizliTutar { get; set; }

        public double KrediHesaplama()
        {
            Console.Write("çekmek istedinizi tutar: ");

            int tutar = int.Parse(Console.ReadLine());
            Console.Write("vade sürenizi giriniz: ");
            int vade = int.Parse(Console.ReadLine());
            this.Vade = vade;
            this.Tutar = tutar;
            this.FaizliTutar = this.Tutar + ((this.Tutar * this.Vade * FaizOrani) / 100);
            return Math.Round(FaizliTutar, 2);


        }

        public void Aciklama()
        {
            Console.WriteLine("aylık ödeme tutarınız: " + Math.Round((this.FaizliTutar / this.Vade)), 2);

            Console.WriteLine(Math.Round(FaizliTutar, 2));
        }

    }
}
