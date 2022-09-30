using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank1
    {
        private int customerid;
        private string customername;
        private int numberofcustomer;
        private int noofemployee;
        private int noofmanager;
        private int nonmanager;
        private int noofclerck;
        public int result;
        
        public int customerId
        {
            set { customerid = value; }
            get { return customerid; }
            
            
        }
        public string customerName
        {
            set { customername = value; }
            get { return customername; }
        }
        public int Numberofcustomer
        {
            set { numberofcustomer = value; }
            get { return numberofcustomer; }    
        }
        public int Numberofemployee
        {
            set { noofemployee = value; }
            get { return noofemployee; }
        }
        public int Noofmanager
        {
            set { noofmanager = value; }
            get {  return noofmanager;}
        }
        public int Nonmanager
        {
            set { nonmanager = value; }
            get { return nonmanager;}   
        }
        public int Noofclerck
        {
            set { noofclerck = value; }
            get { return noofclerck;}   
        }
        public int Add()
        {
           return result = customerId + Numberofcustomer + Numberofemployee + Noofmanager + Nonmanager + Noofclerck;
            return result;
        }
    }
}
