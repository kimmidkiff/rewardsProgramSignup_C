using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Person_and_Customer
{
    abstract class Person
    {
        // constructor
        public Person(string name, string address, int number) 
        {
            Name = name;
            Address = address; 
            Number = number;
        }
        
        // concrete
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
    }
}
