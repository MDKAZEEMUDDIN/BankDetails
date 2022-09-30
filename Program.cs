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
            Console.WriteLine("Customer id is :  "+b.customerId);
            Console.WriteLine("Customer Name is :"+b.customerName);
            Console.WriteLine("Number of customer is :"+b.Numberofcustomer);
            Console.WriteLine("Number of employees is :"+b.Numberofemployee);
            Console.WriteLine("Number of Manager is :"+b.Noofmanager);
            Console.WriteLine("Number of non manager is :"+b.Nonmanager);
            Console.WriteLine("Number of clerck is :"+b.Noofclerck);
            Console.WriteLine(b.result);
            b.Add();
    }
}
}
