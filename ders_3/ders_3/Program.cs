using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array double örneği
            /*double[] sayilar = { 3.14, 5.6, 7.3};

            Console.WriteLine(
                "Array 0. index= " + sayilar[0] + "\n" +
                "Array 1. index= " + sayilar[1] + "\n" +
                "Array 2. index= " + sayilar[2]);
            Console.ReadLine();
            */
            /*
             * List mantığı
            List<string> isimler = new List<string>();

            isimler.Add("ali");
            isimler.Add("veli");
            isimler.Add("yiğit");
            //isimler.AddRange(new List<string> { "mert", "canan"});

            foreach (var item in isimler) 
                Console.WriteLine(item);


            //isimler.Remove("ali"); 
            //isimler.RemoveAt(1); //şu indexteki itemı sil 
            //isimler.RemoveRange(0,2);//0.itemden başla 2 tanesini sil

            

            //isimler.Clear(); //açık sarılar method parantez aç ve kapa parametre gerekir
            //clear ile listeyi tamamen boşalttık

            isimler.Insert(1, "Yeni Kişi"); // add en sona ekler, insert için index verirsiniz araya ekler -verilen index sayısının yerine-
            Console.WriteLine(isimler.Count());

            Console.WriteLine("*************************");
            foreach (var item in isimler)
                Console.WriteLine(item);
            */

            /*Console.WriteLine("Lütfen yaşınızı giriniz= ");
            int age = int.Parse(Console.ReadLine()); //convertten daha hızlı ama convert daha yetenekli

            Console.WriteLine("Yaşınız: " + age);
            */
            /*
            string age = "25";
            int int_age = Convert.ToInt32(age);

            bool dogru = true;
            //int bool_dogru = int.Parse(dogru); //convert edemiyor, mutlaka string ifade görmek ister
            int bool_dogru = Convert.ToInt32(dogru); //convert daha masraflı 
            Console.WriteLine(dogru);
            */

            /*
            string date = "15.05.1999 21:40";
            DateTime my_birth = Convert.ToDateTime(date);

            Console.WriteLine(my_birth);
            Console.ReadLine();
            */

            //karar mekanizmaları

            /*Console.WriteLine("Lütfen bir sayı giriniz: ");

            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else 
            {
                Console.WriteLine("Sayı tektir.");
            }
            */

            /*Console.WriteLine("Lütfen notunuzu giriniz: ");

            int note = int.Parse(Console.ReadLine());

            if (note < 40)
            {
                Console.WriteLine("Kaldınız...");
            }
            else if(note < 50)
            {
                Console.WriteLine("Geçtiniz. 2 aldınız.");
            }
            else if (note < 70)
            {
                Console.WriteLine("Geçtiniz. 3 aldınız.");
            }
            else if (note < 85)
            {
                Console.WriteLine("Geçtiniz. 4 aldınız.");
            }
            else if (note < 101)
            {

                if (95< note)
                {
                    Console.WriteLine("Tebrikler.");
                }
                Console.WriteLine("Geçtiniz. 5 aldınız.");
            }
            else
            {
                Console.WriteLine("Geçersiz not girişi.");
            }
            */

            /*Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir isim giriniz: ");
            string isim = Console.ReadLine();

            if (isim == "murat" || sayi <5 || sayi %2 == 0)  // ve -->&& *** veya -->|| *** 
            {
                Console.WriteLine("İsminiz murat ve/veya sayı 5 ten küçüktür.");
            }
            else
            {
                Console.WriteLine("değildir.");
            }
            */
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi + sayi2 < 100)
            {
                Console.WriteLine("toplam 100 den küçük");
            }
            else
            {
                Console.WriteLine("toplam 100 den büyük");
            }
            Console.ReadLine();
        }
    }
}
