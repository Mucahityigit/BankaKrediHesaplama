using System;

namespace BankaKrediHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //müşteri gelecek 
            //ben kredi çekecem
            //karşılaştıralım --beklemede
            //en az 4 tane kredimiz var
            //karşılaştırma listesi
            //
            //IKrediler krediCek = new IhtiyacKredisiManager();
            //krediCek.Tutar = 2;
            //krediCek.Vade = 10;

            //Console.WriteLine(krediCek.KrediHesaplama());
            //Console.Read();

            //IKrediler tasitKredisi = new TasitKredisiManager();
            //tasitKredisi.Tutar = 20000;
            //tasitKredisi.Vade = 10;

            //Console.WriteLine(tasitKredisi.KrediHesaplama());
            //Console.Read();


            //IKrediler egitimKredisi = new EgitimKredisiManager();
            //egitimKredisi.Tutar = 20000;
            //egitimKredisi.Vade = 10;

            //Console.WriteLine(egitimKredisi.KrediHesaplama());
            //Console.Read();


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1-İhtiyaç Kredisi: ");
                Console.WriteLine("2-Taşıt Kredisi");
                Console.WriteLine("3-Konut Kredisi");
                Console.WriteLine("4-Eğitim Kredisi: ");

                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                Karar kredi = new Karar();

                switch (secim)
                {
                    case "1":

                        kredi.KrediCek(new IhtiyacKredisiManager());
                        break;
                    case "2":
                        kredi.KrediCek(new TasitKredisiManager());
                        break;
                    case "3":
                        kredi.KrediCek(new KonutKrediManager());
                        break;
                    case "4":
                        kredi.KrediCek(new EgitimKredisiManager());
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("İyi günler dileriz size kredi mredi yok");
                        Environment.Exit(0);
                        break;
                }
            }
        }

    }
}
