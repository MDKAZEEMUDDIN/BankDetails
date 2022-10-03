using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Dog : IAnimal
    {
        public void animalvoice()
        {
            Console.WriteLine("Dog make sound bow bow ");
        }
        internal class Snake : IAnimal
        {
            public void animalvoice()
            {
                Console.WriteLine("Snake make noice Hiss");
            }
        }

    }
}
