using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //string bir reference type
            //IPerson student = new Student(1, "Ahmet");
            //IPerson user = new User(2, "Veli");

            //Person student = new Student(1, "Ahmet");
            //Person user = new User(2, "Veli");

            /*Personnel person = new Worker(1, "Ahmet", "IT");
            person.BreakTime();

            Personnel emp = new Employee(1, "Fırat", "IT");
            emp.BreakTime();
            */

            /*Square square = new Square();
            square.Draw();

            Circle circle = new Circle();
            circle.Draw();

            Console.ReadLine();
            */
            /*Shape s = new Shape();
            s.Hi();
            s.name = " ";*/

            Console.ReadLine();
        }
    }
    //bir class birden çok interfacei gerçekleştirir - tersi olmaz, interfacein içindeki tüm methodların gerçekleştirilmesi gerekir
    //interface yapısında çalışan ama object türetilmeyen class ise abstract classtır farkı tanımlanan methodların gövdesi olmalıdır ama impleme etmek zorunda değilsindir
    //abstract problemi methodları o belirler, sadece kendisi çalışır - bunun çözümü polymorphism
    //başında(#)region myregion alanı /  ctrl + k + s ile olur. #endregion ile kapatılır
    /*interface IPerson
    {
        int id { get; set; }
        string name { get; set; }

        void Add();
        void Delete();
        void Update();

    }

    class Student : IPerson
    {
        public Student(int Id, string Name)
        {
            id = Id;
            name = Name;

        }

        public int id { get; set; }
        public string name { get; set; }

        public void Add() 
        {
            Console.WriteLine(name + " adlı öğrenci eklendi.");
        }
        public void Delete()
        {
            Console.WriteLine(name + " adlı öğrenci silindi.");

        }
        public void Update()
        {
            Console.WriteLine(name + " adlı öğrenci güncellendi.");
        }
    }

    class User : IPerson
    {
        public User(int Id, string Name)
        {
            id = Id;
            name = Name;

        }
        public int id { get; set; }
        public string name { get; set; }

        public void Add()
        {
            Console.WriteLine(name + " adlı kullanıcı eklendi.");
        }
        public void Delete()
        {
            Console.WriteLine(name + " adlı kullanıcı silindi.");

        }
        public void Update()
        {
            Console.WriteLine(name + " adlı kullanıcı güncellendi.");
        }
    }
    */

    /*abstract class Person //newleyemezsin constructor eklenebilir
    {
        public Person(int Id, string name)
        {
            this.Id = Id;
            this.Name = Name;
            Console.WriteLine(this.Id + " çalıştı.");
        }
        
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add()
        {
            Console.WriteLine(this.Name + " eklendi.");
        }
        public void Delete()
        {
            Console.WriteLine(this.Name + " silindi.");

        }
        public void Update()
        {
            Console.WriteLine(this.Name + " güncellendi.");
        }

    }

    class Student : Person 
    {
        public Student(int Id, string Name) : base(Id, Name)
        {
            Console.WriteLine("Child class constructor işlemi");
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add()
        {
            Console.WriteLine(this.Name + " eklendi.");
        }
        public void Delete()
        {
            Console.WriteLine(this.Name + " silindi.");

        }
        public void Update()
        {
            Console.WriteLine(this.Name + " güncellendi.");
        }
    }

    class User : Person
    {
        public User(int Id, string Name) : base(Id, Name)
        {
            Console.WriteLine("Child class constructor işlemi");
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add()
        {
            Console.WriteLine(this.Name + " eklendi.");
        }
        public void Delete()
        {
            Console.WriteLine(this.Name + " silindi.");

        }
        public void Update()
        {
            Console.WriteLine(this.Name + " güncellendi.");
        }
    }
    */

    /*abstract class Personnel
    {
        int _id; string name, department;
        public int id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        protected Personnel(int id, string name, string department)
        {
            _id = id;
            this.name = name;
            this.department = department;
            Console.WriteLine("parent constructor çalıştı.");
        }
        public void work()
        {
            Console.WriteLine(name + " personel üretiyor...");
        }

        public virtual void BreakTime() 
        {
            //Console.WriteLine(name + " personeli için mola zamanı");
            Console.WriteLine("Herkes için mola zamanı.");
        }
    }

    class Worker : Personnel //kalıtım yaptık
    {
        public Worker(int Id, string name, string department) : base(Id, name, department) //ana classdan bahsediyoruz
        {
            Console.WriteLine("child constructor çalıştı...");
        }
        public override void BreakTime()
        {
            base.BreakTime();//miras aldığın yerdeki break time ı çalıştır
            Console.WriteLine(Name + "işçisi 30 dk mola kullandı.");
        }
    }
    class Employee : Personnel
    {
        public Employee(int Id, string name, string department) : base(Id, name, department)
        {
            Console.WriteLine("child constructor çalıştı...");
        }

        public override void BreakTime()
        {
            //base.BreakTime();
            Console.WriteLine(Name + "yöneticisi 60 dk mola kullandı.");
        }
    }*/

    /*abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base method çağrıldı.");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Kare çizildi.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Çember çizildi.");
        }
    }
    */

    public class Shape // classın access modifier ı default olarak internal - bulundukları proje içerisinden erişilebilir demek
    {
        //protected int i; // miras alınan class(child) ctor ve ya method içerisinde i ye ulaşabilirsin - protected
        protected internal string name;
        /*public void Hi() 
        {
            Console.WriteLine("Merhaba");
        }*/
    }

    class B : Shape 
    {
        /*void Dene() 
        {
            i = 3;
        }*/

        public B()
        {
            //i = 5;
            name = "Ali";
        }

        
    }
}
