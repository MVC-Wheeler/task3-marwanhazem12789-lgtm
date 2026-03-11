using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public override string ToString()
        {
            return $"Student ID : {StudentId} Course ID : {CourseId} ";
        }
    }
}
