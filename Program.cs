using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacultyID { get; set; }
        public int Group { get; set; }

        public Student(int id, string name, int facultyID, int group)
        {
            this.Id = id;
            this.Name = name;
            this.FacultyID = facultyID;
            this.Group = group;
        }
    }
}
