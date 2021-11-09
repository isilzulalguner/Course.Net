using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Lütfen bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int even = 0;
            int odd = 0;

            for (int i = 0; i < number; i++) 
            { 
                if (i % 2 == 0) 
                { 
                    even += i; 
                }
                else
                {
                    odd += i;    
                }

            }

            Console.WriteLine("Çift sayıların toplamı= " + even); 
            Console.WriteLine("Tek sayıların toplamı= " + odd); 
            
            Console.ReadLine();
            */

            /* foreach kullanımı
             
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int sayi in numbers)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
            */

            //-------------METHODLAR---------------

            //WriteToConsole(50);

            //string[] names = { "Yiğit", "Sude", "Murat", "Mert", "Canan"};

            //Greet("Ali"); //overloading isim aynı parametre farklı
            // Greet(names);

            //Cikar(20, 8);
            //Cikar(num2: 8, num1: 20);



            //Console.WriteLine(DateOfToday());

            Console.WriteLine(BugunGunlerdenNe());
            
            Console.WriteLine(HangiYıl());
            Console.ReadLine();

        }

        /*static void WriteToConsole(int maxNumber) 
        {
            for (int i = 1; i < maxNumber; i++)
            {
                Console.Write(i + " - ");
                
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
        */
        /*
         * methodlar
        static void Greet()
        {


        }

        static void Greet(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        static void Greetg(string name)
        {
            Console.WriteLine("Merhaba " + name);
        }
        
        
         */

        /*static void Cikar(int num1, int num2) //opsiyonel parametre kullanımı -- int num2  = 5
        {
            Console.WriteLine(num1 - num2);

        }
        */

        /*static DateTime DateOfToday() // geriye datetime tipinde veri döndüreceksin demek
        {
            return DateTime.Now;
        }
        */

        static string BugunGunlerdenNe() 
        {
            DayOfWeek today = DateTime.Now.DayOfWeek;
            
            
            switch (today)
            {
                case DayOfWeek.Monday:
                    return "Pazartesi";      
                case DayOfWeek.Tuesday:
                    return "Salı";
                case DayOfWeek.Wednesday:
                    return "Çarşamba";
                case DayOfWeek.Thursday:
                    return "Perşembe";                case DayOfWeek.Friday:
                    return "Cuma";
                case DayOfWeek.Saturday:
                    return "Cumartesi";
                case DayOfWeek.Sunday:
                    return "Pazar";
                default:
                    Console.WriteLine("Geçersiz.");
                    break;
         
            }

            return "Geçersiz";
            //return DateTime.Now;
        }

        static int HangiYıl() 
        {
            return DateTime.Now.Year;
        }
    }
}
