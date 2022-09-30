using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank1 b = new Bank1();
             b.customerId = 123;
            b.customerName = "sameer";
            b.Numberofcustomer = 53;
            b.Numberofemployee = 10;
            b.Noofmanager = 1;
            b.Nonmanager = 0;
            b.Noofclerck = 5;
            Console.WriteLine(" "+b.customerId);
            Console.WriteLine(""+b.customerName);
            Console.WriteLine(""+b.Numberofcustomer);
            Console.WriteLine(""+b.Numberofemployee);
            Console.WriteLine(""+b.Noofmanager);
            Console.WriteLine(""+b.Nonmanager);
            Console.WriteLine(""+b.Noofclerck);
            Console.WriteLine(b.result);
            b.Add();
    }
}
}
