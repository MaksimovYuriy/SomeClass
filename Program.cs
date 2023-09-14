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
            Student p = new Student(1, "Name", 1, 10);
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

        public void getInfo()
        {
            Console.WriteLine("ID студента: ", this.Id);
            Console.WriteLine("Имя студента: ", this.Name);
            Console.WriteLine("ID факультета: ", this.FacultyID);
            Console.WriteLine("Группа студента: ", this.Group);
        }
    }
}
