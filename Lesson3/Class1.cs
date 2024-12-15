using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;


// that does smth that i cant understand
namespace Lesson3
{
    class Human
    {
        private static int Age;
        public static string Name { get; set; }
    }
    class Student : Human
    {
        public static int Group { get; set; }
    }
    class Group
    {
        List<Student> student { get; set; }
        public static string Faculty { get; set; }
    }
}
