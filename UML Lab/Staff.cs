using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Staff:Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string school, double pay, string name, string address) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return "Staff [" + base.ToString() + $"{School} {Pay}]";
        }
    }
}
