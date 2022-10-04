using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object of derived class
            Modifiedcar M=new Modifiedcar();
            M.name = "maruti suzuki brezza";
            //Accesing the method from own class
            M.display();
            M.getName();

        }
    }
}
