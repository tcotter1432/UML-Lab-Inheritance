﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Student:Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string program, int year, double fee, string name, string address) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public override string ToString()
        {
            return "Student [" + base.ToString() + $"{Program} {Year} {Fee}]";
        }
    }
}
