using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_13
{
    class Program
    {
        //global değişken = class a tanımlarsan class içerisindeki methodlarda ulaşabilir
        static int Result;
        static bool CikisYapilsinMi = false;
        static List<int> UserNumbers = new List<int>();

        static void Main(string[] args)
        {
            while (!CikisYapilsinMi)
            {
                ShowMenu();
                Console.WriteLine("Seçiminizi belirtiniz: ");
                int UserChoice = int.Parse(Console.ReadLine());
                KullanicidanDegerleriAl();
                switch (UserChoice)
                {
                    case 1:
                        if (!IslemYapilabilirMi())
                            break;
                        Console.WriteLine("Toplama Sonucunuz : " + Addition(UserNumbers));
                        break;

                    case 2:
                        if (!IslemYapilabilirMi())
                            break;
                        Console.WriteLine("Çıkarma Sonucunuz : " + Subtract(UserNumbers));
                        break;

                    case 3:
                        if (!IslemYapilabilirMi())
                            break;
                        Console.WriteLine("Çarpma Sonucunuz : " + Multiply(UserNumbers));
                        break;

                    case 4:
                        if (!IslemYapilabilirMi())
                            break;
                        Console.WriteLine("Bölme Sonucunuz : " + Divide(UserNumbers));
                        break;

                    case 5:
                        if (!IslemYapilabilirMi())
                            break;
                        Console.WriteLine("Ortalama : " + Average(UserNumbers));
                        break;

                    case 6:
                        UserNumbers.Clear();
                        KullanicidanDegerleriAl();
                        break;

                    case 0:
                        CikisYapilsinMi = true;
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }
            }
            

            Console.ReadLine();
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------MENU--------");
            Console.WriteLine("1. Toplama İşlemi");
            Console.WriteLine("2. Çıkarma İşlemi");
            Console.WriteLine("3. Çarpma İşlemi");
            Console.WriteLine("4. Bölme İşlemi");
            Console.WriteLine("5. Ortalama İşlemi");
            Console.WriteLine("6. Yeni Sayılar Gir");
            Console.WriteLine();
            Console.WriteLine("0. Menüden Çık");
        }

        static void KullanicidanDegerleriAl() 
        {
            string GirisDegeri = "";
            while (GirisDegeri != ".")
            {
                try
                {
                    GirisDegeri = Console.ReadLine();
                    UserNumbers.Add(GirisDegeri.ConInt());
                }
                catch 
                {
                    Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                }
                
            }
        }

        static int Addition(List<int> numbers)
        {
            Result = 0;
            foreach (var item in UserNumbers)
            {
                Result += item;
            }
            return Result;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Result += numbers[i];
            //}
            //return 1;
        }

        static int Subtract(List<int> numbers)
        {
            Result = 0;
            foreach (var item in UserNumbers)
            {
                Result -= item;
            }
            return Result;
        }

        static int Multiply(List<int> numbers)
        {
            Result = 1;
            foreach (var item in UserNumbers)
            {
                Result *= item;
            }
            return Result;
        }

        static int Divide(List<int> numbers)
        {
            Result = numbers[0];
            for (int i = 1; i <numbers.Count(); i++)
            {
                Result /= numbers[i];
            }
            return Result;
        }

        static int Average(List<int> numbers)
        {
            Result = Addition(numbers);
            Result = Result / numbers.Count();
            return Result;
            
        }

        static bool IslemYapilabilirMi() 
        {
            if (UserNumbers == null)
            {
                Console.WriteLine("Listeye Eleman Ekleyiniz.");
                UserNumbers = new List<int>();
                return false;
            }

            if (UserNumbers.Count == 0)
            {
                Console.WriteLine("Listeye Eleman Ekleyiniz.");
                return false;
            }
            return true;
        }

    }
   
    static class Helper
    {
        //integer'a çevirebilmesi için
        public static int ConInt(this object param)
        {
            return Convert.ToInt32(param);
        }
    }



}
