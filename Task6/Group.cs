using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Task6
{
    public class Group:Department
    {
        public string Group_name{ get; set; }
        public Person Leader{ get; set; }
        public List<Person> Group_students = new List<Person>();
        public static List<Group> Groups = new List<Group>();
        public Group(){Groups.Add(this);}
        public Group(string faculty_name,string department_name, bool IsProfiling, Teacher Head,string name,Student person):base(faculty_name,department_name,IsProfiling,Head)
        {
            Group_name = name;
            Leader = person;
            Group_students.Add(person);
            Groups.Add(this);
        }
        public void Add_students(Person p1)
        {
            this.Group_students.Add(p1);
        }
        public override string ToString()
        {
            return
                $"Факультет -   {Faculty_name}\nКафедра -   {Department_name}\nГруппа -   {Group_name}\nСтароста группы -   " +
                $"{Leader}\nСписок студентов группы:  {Show_list(Group_students)}.";
        }

        public static void Create_fac()
        {
            Console.WriteLine("\nВведите название факультета:");
            string fac = Console.ReadLine();
            var facc = new Faculty(fac);
        }

        public static void Create_dep()
        {
            Console.WriteLine("\nВведите название кафедры:");
            string caf = Console.ReadLine();
            Console.WriteLine("\nВведите имя главкафедры:");
            string glavcaf = Console.ReadLine();
            var glavcaff = new Teacher{Name=glavcaf};
            Heads.Add(glavcaff);
            var caff = new Department{Department_name = caf,Head = glavcaff};
        }
        public static void Create_group()
        {
            Console.WriteLine("\nВведите название группы:");
            string gp = Console.ReadLine();
            Console.WriteLine("Введите имя старосты:");
            string star = Console.ReadLine();
            var starr = new Student{Name=star};
            var gpp = new Group{Group_name = gp,Leader = starr};
        }
        public static void Add_students()
        {
            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();
            var stud = new Student{Name=name};
            
        }
    }
}