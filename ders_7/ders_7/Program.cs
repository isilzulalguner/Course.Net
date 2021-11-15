using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BankAccount account = new BankAccount(1250);

            Console.WriteLine(account.GetBalance());
            account.Deposit(1000);
            Console.WriteLine(account.GetBalance());
            account.WithDraw(500);
            Console.WriteLine(account.GetBalance());
            
            Console.ReadLine();
            */
            /*
            Person p = new Person();
            p.Name = "Erkin";
            p.Age = 21;
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            */

            /*
            Age y = new Age();
            Console.WriteLine("Lütfen yaşınızı giriniz= ");
            
            y.Yas = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            */
            /*Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            Console.WriteLine(Cat.count); //cat3.count dersen hata verir anlamaz, classtaki staticten ötürü
            Console.ReadLine();
            */

            /*Dog.Bark(); //cat3.count dersen hata verir anlamaz, classtaki staticten ötürü
            Console.ReadLine();

            Console.WriteLine(Mat.One);
            Console.ReadLine();
            */

            //Person p = new Person("Ali");
            //Console.WriteLine(p.Isim);

            Console.ReadLine();

        }
    }

    /*class BankAccount
    {
        private double balance = 0;

        public BankAccount()
        {

        }

        public BankAccount(double Balance)// constructor yapısı - ctor methodlar overload edilebilir, class ilk inşa edilirken çalışacak method
        {
            balance = Balance;
        }

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
    */

    /* class Person
    {
        /*string _name;// field - dikdörtgenler prizması -her propertyninde bir fieldı var 
        int _age;

        public string Name//property - anahtar şekli - kelimenin ilk harfi büyük
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        

        public string Name { get; set; } = "Erkin";// filed set ettik - initialize value 
        public int Age { get; set; }
    }
    */

    /*class Age
    {
        int _yas; // int e değer vermezsen default 0 dır

        public int Yas 
        {
            get { return _yas; }
            set 
            {
                
                if (value <= 18)
                {
                    Console.WriteLine("Giremezsiniz!");
                }
                else
                {
                    _yas = value; //18 den büyükse set edilecek!!
                    Console.WriteLine("Ne halin varsa gör!");
                }
                
            }
        }
    }
    */

    /*class Cat
    {
        public static int count = 0; //static field ya da classlar bir obje yaratılmadan erişelebilirler.

        public Cat() 
        {
            count++;
        }
    }*/

    /*class Dog
    {
        public static void Bark() 
        {
            Console.WriteLine("Woof");
        }
    }*/

    /*class Mat
    {
        
        public const int One = 1; //const yerine staticte yazılabilir

        public static int X { get; set; }
        public static int Y { get; set; }

        static Mat()       //(int x, int y) --> bu elemanlar dışarıdan set edemeyiz static'in mantığı bu zaten
        {
            //X = x; // nö
            //Y = y; // nö

            X = 10;
            Y = 20;
        }

    }*/

    /*class Person
    {
        string name; //private tanımlarken _ adettendir.

        public Person(string name)
        {
            this.name = name; // bulunduğu scoopu kasteder(this)
        }
    }
    */

    class Person
    {
        readonly string name2;

        private readonly string name;//= "John"; readonly e başlangıç değeri vermek zorunda değilsin js-let

        public const double Pi = 3.14; //başlangıç değeri vermeden kullanmana izin vermez - const her zaman dolu olmalı zorunlu

        public Person(string name)
        {
            this.name = name;
        }

        public string Isim 
        { 
            get { return this.name;  } 
        }
    }
   
}
