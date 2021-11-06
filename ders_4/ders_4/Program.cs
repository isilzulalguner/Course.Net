using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Lütfen bir sayı giriniz= ");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı giriniz= ");
            int sayi2 = int.Parse(Console.ReadLine());

            int toplam = sayi + sayi2;

            if (toplam >= 100) 
            {
                Console.WriteLine("Girdiğiniz sayılar 100 e eşittir ya da 100 den büyüktür .");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayılar 100 den küçüktür.");
            }
            */
            /*Console.WriteLine("Lütfen sayı giriniz= ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool divideTwo = number % 2 == 0;
            bool divideThree = number % 3 == 0;
            string message;

            if (divideTwo && divideThree)
            {
                message = "Girdiğiniz sayı 2 ve 3 e bölünebilir.";
            }
            else if (divideTwo)
            {
                message = "Girdiğiniz sayı 2 ye bölünüyor.";
            }
            else if (divideThree)
            {
                message = "Girdiğiniz sayı 3 e bölünüyor.";
            }
            else
            {
                message = "Bu ne biçim sayı!";
            }

            Console.WriteLine(message);
            //***************************
            Console.WriteLine("Lütfen bir sayı giriniz= ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0 && sayi % 3 == 0)
            {
                Console.WriteLine("Sayı hem 2 ye hem de 3 e tam bölünebilir.");
            }
            else if (sayi % 2 == 0 && sayi % 3 != 0) 
            {
                Console.WriteLine("Sayı sadece 2 ye tam bölünebilir. 3 e tam bölünemez.");
            }
            else if (sayi % 2 != 0 && sayi % 3 == 0)
            {
                Console.WriteLine("Sayı sadece 3 ye tam bölünebilir. 2 e tam bölünemez.");
            }
            else
            {
                Console.WriteLine("Bu ne biçim sayı!");
            }
            */

            /*Console.WriteLine("Lütfen kullanıcı adınızı giriniz= ");
            string username = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz= ");
            int password = Convert.ToInt32(Console.ReadLine());

            bool trueUsername = username == "Aysel";
            bool truePassword = password == 123456;

            if (trueUsername && truePassword)
            {
                Console.WriteLine("Giriş Başarılı !");
            }
            else if (trueUsername)
            {
                Console.WriteLine("Kullanıcı adı doğru. Şifre yanlış.");
            }
            else if (truePassword)
            {
                Console.WriteLine("Kullanıcı adı bulunamadı.");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı ve şifre yanlış.");
            }

            
            Console.ReadLine();
            */

            /*int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay no'su");
                    break;
            }

            Console.ReadLine();
            */

            /*int sayi = 0;

            while (sayi <5)
            {
                Console.WriteLine(sayi);
                sayi++; //sayi = sayi +1 -- sayi +=1
            }
            */

            /*int sayi = 5;

            while (sayi > 0)
            {
                Console.WriteLine(sayi);
                sayi--; //sayi = sayi +1 -- sayi +=1
            }
            Console.ReadLine();
            */

            /*Console.WriteLine("Kullanıcı adınızı giriniz--- Ali");
            Console.WriteLine("Şifrenizi giriniz: ");
            string password = Console.ReadLine();

            bool isCorrect = false;

            while (isCorrect == false)
            {
                if (password == "123456")
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Şifre yanlış, tekrar deneyiniz.");
                    password = Console.ReadLine();
                }
            }

            Console.ReadLine();
            */

            //NOT const double pi = 3.14; //constant on kısaltılışı, değer burada atanmalı sonradan değiştirilemez pi = 3.15; diyemezsin.

            //x++; +1 ekler
            //x--; -1

            /*int x = 5;

            //int y = ++x; önce arttırdık sonra eşitledik prefix ve postfix
            //int y = x--; önce eşitledik sonra eksilttik y=3  x=2

            //bir kez çalışsın sonra devamı conditiona bağlı olsun diyorsan do - while!
            do
            {
                Console.WriteLine(x);
                x++;

            } while (x < 5);


            Console.ReadLine();*/
            //10 a kadar olan sayıların toplamı
            /*int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                toplam += i;
            }

            Console.WriteLine(toplam);
            Console.ReadLine();
            */

            /*string[] isimler = { "fatma", "kaan", "zülal" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
            */
            int toplam = 0;


             for (int i = 0; i < 10; i++)
             {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
                
             }

            Console.WriteLine(toplam);
            Console.ReadLine();


        }
    }
}
