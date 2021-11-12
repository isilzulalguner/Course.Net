using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi1 = 5;

            Console.WriteLine("Method öncesi sayı: " + sayi1);
            SayiArttir(ref sayi1);//methodtaki refi belirtiyoruz
            Console.WriteLine("Method sonrası sayı=" + sayi1);

            Console.ReadLine();
            */

            /*
            string[] isimler = { "Mehmet", "Ahmet"};
            IsimYazdir(isimler);
            Console.ReadLine();
            */


            /*int[] numbers = { 10, 7, 22, 678, 34234, 3434, 4366};
            EnBuyukSayiyiBul(numbers);
            EnBuyukSayiyiBul(10, 7, 22, 678, 34234, 3434, 4366);
            Console.ReadLine();
            */

            /*Console.WriteLine(Fact(4));
            Console.ReadLine();
            */


            /*Console.WriteLine("Lütfen kısa kenarı giriniz= ");
            int kısaKenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz= ");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());

            

            alanHesapla(kısaKenar, uzunKenar);
            */

            /*Person person = new Person();//instance almak - classtan türetilen nesne 

            person.Greet();
            */

            /*Dog d = new Dog();
            d.age = 5;
            d.name = "Daisy";

            Console.WriteLine(d.age);
            Console.WriteLine(d.name);

            Console.ReadLine();
            */

            /*Kus k = new Kus();
            k.age = 1;
            k.name = "Maviş";
            k.cins = "Muhabbet";
            k.Ot();

            Console.WriteLine(k.age);
            Console.WriteLine(k.name);
            Console.WriteLine(k.cins);
           
            Console.ReadLine();
            */

            BankAccount account = new BankAccount();

            Console.WriteLine(account.GetBalance());
            account.Deposit(1000);
            Console.WriteLine(account.GetBalance());
            account.WithDraw(500);
            Console.WriteLine(account.GetBalance());

            Console.ReadLine();
        }

        /*static void SayiArttir(ref int sayi1) // value type'tan referance type'a dönüştürüldü(referans gösterdiğim sayıyı al demek bir bakıma) - ref illa assign edilmeli
        {                                      // ref yerine out yazarsan, başlangıç değeri verilemeyecekse kullanılır, başka bir değişken set edilecekse 
            sayi1 += 5;
        }
        */

        /* static void IsimYazdir(string[] isim) //isimlendirme önemli değil parametredeki data type önemlidir
         {
             foreach (var item in isim)
             {
                 Console.WriteLine(item);
             }

         }
        */

        /*static void EnBuyukSayıyıBul(int[] maxNumber) //isimlendirme önemli değil parametredeki data type önemlidir
        {
            int enBuyukSayı = 1;

            for (int i = 0; i < maxNumber.Length; i++)
            {
                if (enBuyukSayı< maxNumber[i])
                {          
                    enBuyukSayı = maxNumber[i];                 
                }
                
            }
            Console.WriteLine("En büyük sayı: " + enBuyukSayı);


        }
        */

        /*static void EnBuyukSayiyiBul(int[] sayilar) // parantez içine params eklenirse direk method içini alıyor
        {
            int enBuyukSayi = -1;

            if( sayilar.Length == 0)
            {
                Console.WriteLine("Array boş");
            }
            else
            {
                foreach (var sayi in sayilar)
                {
                    if(enBuyukSayi < sayi)
                    {
                        enBuyukSayi = sayi;
                    }
                }
            }

            Console.WriteLine(enBuyukSayi);
        }
        */

        /*static int Fact(int sayi) 
        {
            if (sayi == 1)
            {
                return 1;
            }
            return sayi * (Fact(sayi - 1));
        }
        */

        /*static void alanHesapla(int kısaKenar, int uzunKenar) 
        {
            int cevre = 2*kısaKenar+2*uzunKenar ;
            int alan = kısaKenar * uzunKenar;

            Console.WriteLine("Çevre: " + cevre);
            Console.WriteLine("Alan: " + alan);
            

        }
        */

        /*class Person
        {
            int age;
            string name;

            public void Greet()
            {
                Console.WriteLine("Merhaba");
            }
        }
        */

        /*class Dog
        {
            public int age;
            public string name;
        }
        */

        /*class Kus
        {
            public int age;
            public string name;
            public string cins;

            public void Ot() 
            {
                Console.WriteLine("Cik cik!!");
            }
        }
        */

        class BankAccount
        {
            private double balance = 0; //private yazmazisek default olarak private verir

            public void Deposit(double n) 
            {
                balance += n;
            }

            public void WithDraw(double n) 
            {
                balance -= n;
            }

            public double GetBalance() 
            {
                return balance;
            }

        }
    }
}
