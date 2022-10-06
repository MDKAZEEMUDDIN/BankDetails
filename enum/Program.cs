using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Months
        {
            Jan, //6
            Feb, //8
            Mar, //9
            Apr, //4   
            May,  //3  
            June,  //15 
            Jul,    //28
            August, //3
            Sep,    //2
            Oct,    //1
            Nove,   //9
            December,  //1 

        }
          enum Days
          {
            Monday ,//6
            Tuesday, //5
            Wed, //8
            Thurs, //3
            Friday, //5
            Sat, //1
            Sun, //2
        }
        
        static void Main(string[] args)
        {
            int n = (int) Months.June;
            Console.WriteLine(n);
            int m=(int) Days.Friday;  
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
