using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public override string ToString()
        {
            return $"ID :{Id} Title : {Title} Credits: {Credits}";
        }
    }
}
