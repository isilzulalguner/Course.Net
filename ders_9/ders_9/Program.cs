using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Worker worker = new Worker();
            worker.Id =  1;
            worker.Name = "Ahmet";
            worker.Department = "A";

            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Veli";
            employee.Department = "İK";

            Console.WriteLine("ID'si " + worker.Id + " olan ve " + worker.Name + " isimli çalışan " + worker.Department + " departmanında çalışmaktadır.");
            Console.WriteLine("ID'si " + employee.Id + " olan ve " + employee.Name + " isimli çalışan " + employee.Department + " departmanında çalışmaktadır.");
            Console.ReadLine();
             */
            /*
            Cat cat = new Cat();
            cat.Name = "Mila";
            cat.Age = 1;
            Console.WriteLine(cat.Name + " isimli " + cat.Age + " yaşında.");
            cat.Meow();

            Dog dog = new Dog();
            dog.Name = "Zeus";
            dog.Age = 2;
            Console.WriteLine(dog.Name + " isimli " + dog.Age + " yaşında.");
            dog.Bark();

            Bird bird = new Bird();
            bird.Name = "Maviş";
            bird.Age = 1;
            Console.WriteLine(bird.Name + " isimli " + bird.Age + " yaşında.");
            bird.Cik();

            Console.ReadLine();
            */

            // Bir class sadece bir classtan türeyebilir ama bir class birden çok interfaceten üreyebilir.

            IPerson person = new Worker(1, "Ahmet", "IT");//worker ve employee, IPerson gibi aynı depolamayı gösterir - referance type/kopya alıyor
            IPerson person2 = new Employee(1, "Mehmet", "Finance");
            person.Work();
            person.GetSalary();
            person2.Work();
            person2.GetSalary();

            AddPersonel(new Worker (1, "Mert", "IT"));
            AddPersonel(new Employee (1, "Muzaffer", "Accounting"));

            Console.ReadLine();


        }

        static void AddPersonel(IPerson person) //ÖNEMLİ
        {
            Console.WriteLine(person.Name + " isimli bir çalışan işe alındı");
        }

        /*static void AddEmployee(Employee employee)
        {
            Console.WriteLine("Yeni bir yönetici işe alındı");
        }*/

    }

    interface IPerson 
    {
        //interface içinde kod bloğu olmaz / iş yapmaz yaptırır
        int id { get; set; }

        string Name { get; set; }

        string Department { get; set; }

        void Work(); //{} - süslü parantez açamazsın, iş yaptırmaya çalışmış olursun, kabul etmez.
        void GetSalary();
    }

    class Worker : IPerson
    {
        public Worker(int Id, string name, string department)
        {
            id = Id;
            Name = name;
            Department = department;
        }

        public int id { get ; set ; }
        public string Name { get; set; }
        public string Department { get; set; }

        public void GetSalary()
        {
            Console.WriteLine(Name + " çalışanı maaşını çekti.");
        }

        public void Work()
        {
            Console.WriteLine(Name + " çalışanı üretiyor.");
        }
    }

    class Employee : IPerson
    {
        public Employee(int Id, string name, string department)
        {
            id = Id;
            Name = name;
            Department = department;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public void GetSalary()
        {
            Console.WriteLine(Name + " yöneticisi maaşını çekti.");
        }

        public void Work()
        {
            Console.WriteLine(Name + " yöneticisi çalışıyor.");
        }
    }

    

    /*class Person // base class - parent
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

	}*/

    /*class Worker : Person //child
	{
        public void Work()
        {
            Console.WriteLine("İşçi çalışıyor.");
        }
	}*/

    /*class Employee : Person //child
	{
        public void GetSalary()
        {
            Console.WriteLine("Memur maaşını aldı.");
        }
	}*/

    /*class Animal
    {
        protected string _name;
        protected int _age;

        public string Name { get; set; }
        public int Age { get; set; }

    }*/

    /*class Cat : Animal //derived class - miras alan class
    {

        public Cat()
        {
            _name = Name;
            _age = Age;
        }

        public void Meow()
        {
            Console.WriteLine("Meow meow!");
        }
    }*/

    /*class Dog : Animal
    {
        public Dog()
        {
            _name = Name;
            _age = Age;
        }

        public void Bark()
        {
            Console.WriteLine("Bark bark!");
        }
    }*/

    /*class Bird : Animal
    {
        public Bird()
        {
            _name = Name;
            _age = Age;
        }

        public void Cik()
        {
            Console.WriteLine("Cik cik!");
        }
    }*/

}