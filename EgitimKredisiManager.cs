using System;

namespace BankaKrediHesaplama
{
    internal class EgitimKredisiManager : IKrediler
    {
        private int _vade, _tutar;
        public string KrediAdi => "Öğrenci Kredisi";

        public int Tutar
        {
            get => _tutar;
            set
            {
                _tutar = value;
                if (value > 500000)
                {
                    _tutar = 500000;
                    Console.WriteLine("En fazla 500000TL kredi çekebilirsiinz.");
                }
                else if (value < 500)
                {
                    _tutar = 500;
                    Console.WriteLine("En az 500 tl kredi çekebilirsiniz.");
                }
            }
        }


        public double FaizOrani => 2.6;

        public int Vade
        {
            get => _vade; set
            {
                _vade = value;
                if (value<3)
                {
                    _vade = 3;
                        Console.WriteLine("En az 3 ay vadeli kredi çekebilirisinz.");
                }
                else if (value>12)
                {
                    _vade=12;
                    Console.WriteLine("En fazla 12 ay vadeli kredi çekebilirsiniz.");

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
