using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual string ToString()
        {
            return $"Person[{Name}, {Address}";
        }
    }
}
