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
            //Создадим нового студента
            Student p = new Student(1, "Name", 1, 10);
            //Вывод информации о нем
            p.getInfo();

            //Изменим несколько параметров у студента и снова выведем
            p.FacultyID = 2;
            p.Group = 3;
            p.getInfo();
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
            Console.WriteLine("ID студента: {0}", this.Id);
            Console.WriteLine("Имя студента: {0}", this.Name);
            Console.WriteLine("ID факультета: {0}", this.FacultyID);
            Console.WriteLine("Группа студента: {0}", this.Group);
            Console.WriteLine();
        }
    }
}
