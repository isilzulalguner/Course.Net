using ders_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            //s.Hi();
            //ders 11 içerisindeki classı internal olarak bıraksak bu sonuca ulaşamayız

            
            Console.ReadLine();
        }
    }
    class  MyClass : Shape
    {
        //bu claasın içinde ctor kullandığın zaman diğer projeden protected internala ulaşabilirsin
        public MyClass()
        {
            name = " ";
        }
    }
}
