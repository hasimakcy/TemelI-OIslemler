using System;

namespace Temel_IO_Islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //        I/O İngilizce Input/Output'un kısaltmasıdır.

            /*
             Erkan cıktısı icin ornek:
             Hoş geldin 21 yaşındaki Haşim AKÇAY.
             Önümüzdeki yıl 22 yaşında olacaksın.
            */

            // INPUT
            Console.Write("Adınızı giriniz: ");
            string ad;
            ad = Console.ReadLine();
            
            Console.Write("Soyadınızı giriniz: ");
            string soyad = Console.ReadLine();

            Console.Write("Yaşınızı giriniz: ");
            string yas = Console.ReadLine();
            //yas'ı burda int tipinden kullansaydık convert(dönüştürmek) işlemini burda yapmamız gerekirdi.

            // PROCESS
            string cumle = "Hoş geldin " + yas + " yaşındaki " + ad + " " + soyad + ".";            
            //string cumle = $"Hoş geldin {yas} yaşındaki {ad} {soyad}.";
            //İkiside aynı işlemi yapar sadece farklı bir yazım şeklidir.

            int sayisalYas = Convert.ToInt32(yas);
            //yas'ı string olarak aldığımız için 'int' tipini convert etmemiz gerekir.
            int gelecekYas = sayisalYas + 1;

            // string cumle2 = "Önümüzdeki yıl " + (sayisalYas + 1) + " yaşında olacaksın.";
            string cumle2 = $"Önümüzdeki yıl {gelecekYas} yaşında olacaksın."; 
            //string cumle2 = "Önümüzdeki yıl " + gelecekYas + " yaşında olacaksın.";
            

            // OUTPUT
            Console.WriteLine(cumle);
            Console.WriteLine(cumle2);

        }
    }
}
