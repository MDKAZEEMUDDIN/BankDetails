using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interface1.Dog;

namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d=new Dog();
            d.animalvoice();
            Snake  s = new Snake();
            s.animalvoice();
            Console.ReadLine();
        }
    }
}
