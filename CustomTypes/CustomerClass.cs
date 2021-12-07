using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2.CustomTypes
{
    public class CustomerClass
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public CustomerClass()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            Address = "";
            Address2 = "";
            City = "";
            State = "";
            Zip = 0;
        }
    }
}