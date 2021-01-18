using System;

namespace Calısma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string result = a % 2 == 0 ? "cift" : "tek";
            Console.WriteLine(result);

            int number = 1;
            switch (number)
            { 


                case 1:
                    Console.WriteLine("durum 1 "); break;
                case 2:
                    Console.WriteLine("durum 2"); break;


                default:
                    Console.WriteLine("diger durum");
                    break;
            }

            int b = 0;
            int toplam = 0;

            while (b <= 100)
            {
                if (b % 2 == 1)

                    toplam += b;
                b++;






            }

            Console.WriteLine("Tek Sayıların toplamı :" + toplam);


            ürün ürün1 = new ürün();
            ürün1.Fiyati = 35;
            ürün1.ÜrünRengi = "kırmızı";
            ürün1.ÜrünMarkasi = "beymen";

            ürün ürün2 = new ürün();
            ürün2.Fiyati = 455;
            ürün2.ÜrünRengi = "siyah";
            ürün2.ÜrünMarkasi = "koton";

            ürün ürün3 = new ürün();
            ürün3.Fiyati = 124;
            ürün3.ÜrünRengi = "mavi";
            ürün3.ÜrünMarkasi = "zara";

            ürün[] ürünler = new ürün[] { ürün1, ürün2, ürün3 };


            foreach (var ürün in ürünler)
            {
                Console.WriteLine(ürün.Fiyati + ":" + ürün.ÜrünMarkasi);
            }

            string[] marka = new string[] { "beymen", "zara", "koton" };


            for (int i = 0; i < marka.Length; i++)
            {
                Console.WriteLine(marka[i]);

            }
            Console.ReadLine();










        }

        class ürün
        {
            public int Fiyati { get; set; }
            public string ÜrünRengi { get; set; }
            public string ÜrünMarkasi { get; set; }





        }
    }
}
