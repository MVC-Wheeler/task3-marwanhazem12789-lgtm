using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} Name : {Name} Age : {Age} Departement : {Department} GPA : {GPA}";
        }
    }
}
