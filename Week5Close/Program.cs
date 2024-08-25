using Week5Close;
using System;

class Program
{
    static void Main()
    {
        List<Car> arabalar = new List<Car>();

        while (true)
        {
            Console.WriteLine("Araba üretmek ister misiniz? (e/h)");
            string cevap = Console.ReadLine().ToLower();//Büyük küçük harf duyarlılığı

            if (cevap == "h")
            {
                Console.WriteLine("Program Sonlandırılıyor.....");
                break;
            }
            else if (cevap == "e")
            {
                //Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı
                Car yeniAraba = new Car();

                Console.WriteLine("Seri Numarasını Giriniz:");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.WriteLine("Araba Markasını Giriniz:");
                yeniAraba.Marka = Console.ReadLine();

                Console.WriteLine("Araba Modelini Giriniz:");
                yeniAraba.Model = Console.ReadLine();

                Console.WriteLine("Araba Rengini Giriniz:");
                yeniAraba.Renk = Console.ReadLine();



            kapiGirisi: Console.WriteLine("Kapı Sayısını Giriniz:");
                string kapiSayisiGiris = Console.ReadLine();

                try
                {
                    yeniAraba.KapiSayisi = int.Parse(kapiSayisiGiris);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz Giriş Yaptınız.  Lütfen Sayısal bir değer giriniz.");
                    goto kapiGirisi;
                }

                arabalar.Add(yeniAraba);

            }


            else
            {
                Console.WriteLine("Geçersiz Cevap Verdiniz. Lütfen 'e' ya da 'h' Giriniz");
            }


            Console.WriteLine("\nÜretilen Arabalar");
            foreach (Car araba in arabalar)
            {
                Console.WriteLine($"Seri Numarası : {araba.SeriNumarasi}, Marka: {araba.Marka}");

            }

        }

    }
}