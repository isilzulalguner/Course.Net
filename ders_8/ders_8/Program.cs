using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* fieldlar en sade yapılar, temel yapıtaşları. property veya methodlarla bu fieldların kurallarını sağlıyoruz
             * fieldlara direkt ulaşılmasını istemeyiz ve üzerinde işlem yapabilmek için bu ikili gerekli.
             * this.name dersek bu propertyinin fieldı name dir demek.
             * propertyiyi kural koymak için kullanıyoruz, property kullanmadan da field kullanabiliriz.
             */

            /*Person p = new Person();
            Person p2 = new Person(1000);

            p.GetBalance();
            p2.GetBalance();


            Console.ReadLine();
            */

            /*
            User user = new User(); 
            user.Id = 1;
            user.Company = "ANT";
            user.Age = 32;
            user.IsAuthenticated = true;

            User user1 = new User();
            user1.Name = "Ayşe";
            user1.Id = 2;
            user1.Company = "ANT";
            user1.Age = 29;
            user1.IsAuthenticated = false;

            UserManager userManager = new UserManager();
            userManager.AddUser(user);
            userManager.AddUser(user1);
            userManager.DeleteUser(user1);
            

            Console.ReadLine();
            */
            /*
            User user = new User(1, 15, "Ahmet", "Başaran", false);
            UserManager userManager = new UserManager();
            userManager.AddUser(user);
            */

            UserManager userManager = new UserManager();
            userManager.AddUser(new User(1, 15, "Ahmet", "Başaran", false));

            User user = new User(2, 20, "Ayşe", "Başaran", false);
            userManager.AddUser(user);
            User user1 = new User(2, 20, "Ayşe", "Başaran", false);
            userManager.AddUser(user1);

            userManager.DeleteUser(new User(1, 15, "Veli", "Başaran", false));
            Console.ReadLine();
        }
    }

    /*class Person
    {
        // ÖRNEK

        //int _x = 5;

        //public int X { get; set; } = 5;

        double _balance = 0;
        //bu classı her yenilediğimizde balance hep 0.
        public Person() //herhangi bir ctor(constructor) tanımlandığı zaman bu hükümsüz
        {

        }

        public Person(double Balance)
        {
            _balance = Balance;
        }

        public void GetBalance() 
        {
            Console.WriteLine(_balance);
        }

    }*/

    class User
    {
        //ctrl artı + artı . 'ya bas generate constructor dersen kendi otomatik constructorı oluşturur
        int _id, _age; //fieldları seçip ctrl + r + e yaparsan propertyleri(get ve set'liler) otomatik oluşturur.
        string _name, _company;
        bool _isAuthenticated;

        public int Id { get => _id; set => _id = value; }
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string Company { get => _company; set => _company = value; }
        public bool IsAuthenticated { get => _isAuthenticated; set => _isAuthenticated = value; } 


        public User(int Id, int Age, string Name, string Company, bool IsAuthenticated ) //alınan fieldların düzenlenmesi ve sistematik olarak istenen durumlara/kurallara göre tutulabilmesi için
        {
            _id = Id;
            _age = Age;
            _name = Name;
            _company = Company;
            _isAuthenticated = IsAuthenticated;
        }


    }

    class UserManager
    {
        List<User> Users = new List<User>() 
        {
            new User(1, 42, "Mehmet", "Başaran", false)
        };

        public void AddUser(User user)
        {
            //kullanıcı ekleme işlemi
            foreach (var item in Users)
            {
                if (item.Name == user.Name)
                {
                    Console.WriteLine("Bu kullanıcı sistemimize daha önce kaydedilmiştir.");
                    return; // return ile methoddan çıktık.
                }

            }

            Users.Add(user);
            Console.WriteLine(user.Name + " isimli kullanıcı eklendi.");
        }

        public void DeleteUser(User user) 
        {
            //kullanıcı silme işlemi
            foreach (var item in Users)
            {
                if (item.Name == user.Name)
                {
                    Users.Remove(user);
                    Console.WriteLine(user.Name + " isimli kullanıcı silindi.");
                    return; // return ile methoddan çıktık.
                }

            }
            Console.WriteLine(user.Name + " isimli kullanıcı sistemimizde bulunmamaktadır.");
            
        }
    }


}
