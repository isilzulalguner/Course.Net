using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Lütfen adınızı yazınız:");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyadınızı yazınız:");
            string surname = Console.ReadLine();

            string first_letter_of_name = name.Substring(0, 1).ToUpper();
            string first_letter_of_surname = surname.Substring(0, 1).ToUpper();

            string newName = first_letter_of_name + name.Substring(1).ToLower();
            string newSurname = first_letter_of_surname + surname.Substring(1).ToLower();

            string fullName = newName + " " +newSurname;
            
            Console.WriteLine(fullName);

            Console.ReadLine();
            */

            /*string sentence = "Arabam 70 model";

            int number7 = sentence.IndexOf("7");

            string result = sentence.Substring(number7);

            Console.WriteLine(result);
            Console.ReadLine();
            */

            /*int sayi1 = 1;
            int sayi2 = 3;
            int toplam = sayi1 + sayi2;

            Console.WriteLine(
                "1.Sayı = " + sayi1 +
                " 2.Sayı = " + sayi2+
                " Toplam = " + toplam);

            Console.ReadLine();
            */

            //console'a yazılan ve okunan her şey string!!

            /*double pi = 3.14;
            float sayi = 3.14f;
            decimal sayi2 = 3.14M;

            Console.WriteLine(pi);
            Console.ReadLine();
            */

            /*bool value1 = true;
            bool value2 = false;
            bool value3 = 10 > 15;

            Console.WriteLine(value3);
            Console.ReadLine();
            */


            //DateTime dt = new DateTime(2021, 11, 1, 21, 5, 50);

            /*DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Now;
            //veritabanına işlem saati kaydedilirken kullanılacak
            dt = dt.AddDays(5);
            double fark = (dt2 - dt).TotalSeconds;

            Console.WriteLine(dt);
            Console.WriteLine();
            Console.ReadLine();
            */

            /*
            Object
            object str_var = "zülal";
            object int_var = 5;
            object dbl_var = 3.14;
            object dt_var = DateTime.Now;
            object bool_var = false;


            Console.WriteLine(
                "string value = "+ str_var + "\n" +
                "int value = " + int_var + "\n" +
                "double value = " + dbl_var + "\n" +
                "datetime value = " + dt_var + "\n" +
                "boolean value = " + bool_var );
            Console.ReadLine();

            //boxing and Unboxing

            object int_var = 5;
            int sayi = 8;

            int_var = sayi; //boxing

            sayi = (int)int_var; //unboxing --> sayi = int_var; --> bu hatalı - sayıyı kutuya eşitlemek istiyor gibi algılar
            */

            /*int[] sayilar = new int[3]; // 3 item sayısı

            sayilar[0] = 40;
            sayilar[1] = 30;
            sayilar[2] = 20;
            */
            /*
            int[] sayilar = {40, 30 ,20};

            sayilar[1] = 785;  //dinamik yapı
            Console.WriteLine(
                "array 0. index = " + sayilar[0] + "\n" +
                "array 1. index = " + sayilar[1] + "\n" +
                "array 2. index = " + sayilar[2] + "\n");
            Console.WriteLine(sayilar.Length);
            Console.ReadLine();
            */

            string[] names = { "Sümeyra", "Zülal", "Işıl" };

            names[1] = "Özlem";  //dinamik yapı
            Console.WriteLine(
                "array 0. index = " + names[0] + "\n" +
                "array 1. index = " + names[1] + "\n" +
                "array 2. index = " + names[2] + "\n");
            Console.WriteLine(names.Length);
            Console.ReadLine();

        }
    }
}
