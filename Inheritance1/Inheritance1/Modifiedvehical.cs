using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class Modifiedcar : Oldcar   //derived class of animal
    {
        public void getName()
        {
            Console.WriteLine("my new modified car name is :"+name);
        }
    }
}
