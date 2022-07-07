using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTrial
{
    internal class Employee
    {
        //created properties
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        //created constructor
        public Employee(string _name, double _salary, string _position)
        {
            Name = _name;
            Salary = _salary;
            Position = _position;
        }
    }
}
