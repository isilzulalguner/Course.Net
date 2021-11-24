using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //tryparse öğren!
            //transaction - transaction commit --> veritabanına gider yazar

            /*
            try
            {
                Console.Write("lütfen yaşınızı giriniz: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} yaşındasınız.", age);

                //int[] array = new int[2];
                //array[0] = 1;
                //array[1] = 2;
                //Console.WriteLine(array[2]);

                //int x = 3;
                //int y = 0;
                //Console.WriteLine(x / y);
                //transaction.commit();
            }
            catch (IndexOutOfRangeException intex) //bir try içine birden çok catch yazabilirsin
            {
                Console.WriteLine("Hata oluştu. Sebebi : {0}", intex.Message);
            }
            catch (FormatException forex)
            {
                Console.WriteLine("Hata oluştu. Sebebi : {0}", forex.Message); // bu tip kontrolleri log dosyalarına yazarsın incelersin
            }
            catch (DivideByZeroException ex)
            {
                //transaction.Rollback();
                Console.WriteLine("Hata oluştu. Sebebi : {0}", ex.Message); // bu tip kontrolleri log dosyalarına yazarsın incelersin
            }
            finally 
            {
                Console.WriteLine("Mutlaka çalışması gereken kod!");
            }


            Console.ReadLine();
            */

            /*
            Random rnd = new Random();


            while (true)
            {

                Console.WriteLine(rnd.Next(1, 100)); //1 ile 100 arası sayı salla

                Console.WriteLine(rnd.NextDouble() * 100);
                Console.ReadLine();
            }*/

            /*
            int sayi1 = 10;
            int sayi2 = 25;

            Console.WriteLine("İki sayıdan büyük olan {0} dır.", Math.Max(sayi1, sayi2));
            Console.WriteLine("İki sayıdan küçük olan {0} dır.", Math.Min(sayi1, sayi2));

            int number3 = -10;
            Console.WriteLine("Mutlak değer {0} dır.", Math.Abs(number3));

            Console.WriteLine("Karekök {0} dır.", Math.Sqrt(sayi2));

            double number4 = 5.1;
            
            Console.WriteLine("Aşağı yuvarla {0} dır.", Math.Floor(number4));
            Console.WriteLine("Yukarı yuvarla {0} dır.", Math.Ceiling(number4));//ürün listelenecek sayfa sayısını belirlemek için
            Console.WriteLine("Yuvarla {0} dır.", Math.Round(number4));


            //Math m = new Math();
            //m.Abs(number3);  YAZAMAZSIN ÇÜNKÜ STATIC !!! STATIC, ABSTRACT CLASSLARDAN INSTANCE ALINMAZ !!!
            //  SEALED CLASSLAR DA NEWLENEMEZ !!!
            Console.ReadLine();
            */

            /*List<Worker> workers = new List<Worker>
            {
                new Worker(1,"Ali",Position.Bekçi),
                new Worker(2,"Veli",Position.Direktör),
                new Worker(3,"Ayşe",Position.Muhasebeci),
                new Worker(4,"Fatma",Position.Müdür)
                
            };

            Console.ReadLine();
            */

            try
            {
                Game();
            }
            catch (Exception)
            {

                Game();
            }

            /*Random rnd = new Random();
            int rndm = Convert.ToInt32(rnd.Next(1, 50));
            
            try
            {
                for (int hak = 0; hak < 10; hak--)
                {
                    Console.WriteLine("Tahmin de bulununuz: ");
                    int guess = int.Parse(Console.ReadLine());
                    int fark = rndm - guess;
                    Math.Abs(fark);

                    if (fark < 5)
                    {
                        Console.WriteLine("Sıcak");

                    }
                    else if (fark > 5)
                    {
                        Console.WriteLine("Soğuk");
                    }
                    else if (fark == 0) 
                    {
                        Console.WriteLine("Bildiniz!");
                    }
                }
                Console.WriteLine("Bilemediniz!");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: {0}", ex);
            }

            Console.ReadLine();*/
        }

        /*class Worker
        {
            int id;
            string name;

            public Position Position { get; set; }

            public Worker(int ID, string Name, Position position)
            {
                id = ID;
                name = Name;
                this.Position = Position;
            }
        }

        enum Position //scoop olduğu için 0,1,2...gibi görüyor
        {
            Muhasebeci = 1, //= 1 dersen 0 yerine 1 den başlar
            IT=3,
            Bekçi=66,
            Müdür=67,
            Yönetmen, // bir değer vermezsen önceki değerden devam eder ve 68, 69.. diye devam eder
            Direktör
        }
        */
        
        static void Game()
        {
            int number = new Random().Next(1,51);
            int kalanHak = 10;
            Console.WriteLine("Adınız: ");
            string name = Console.ReadLine();

            Console.WriteLine("Tahmininizi giriniz: ");
            int userNumber = int.Parse(Console.ReadLine());

            while (userNumber != number)
            {
                kalanHak--;

                if (Math.Abs(number - userNumber) < 5)
                {
                    Console.WriteLine("Sıcak");
                }
                else 
                {
                    Console.WriteLine("Soğuk");
                    
                }
                Console.WriteLine("Tahmininizi giriniz: ");
                userNumber = int.Parse(Console.ReadLine());

                if (kalanHak==0)
                {
                    Console.WriteLine("Hakkınız bitti {0} maalesef bilemediniz. Sayı {1} idi.", name, number);
                    break;
                }

                
            }

            if (userNumber == number) 
            {
                Console.WriteLine("Tebrikler {0} Bildiniz!!!", name);
            }
        }
        


    }
}
