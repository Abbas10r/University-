using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static Task6.Faculty;
using static Task6.Department;
using static Task6.Student;
using static Task6.Group;

namespace Task6
{
    public class Group:Department
    {
        private static int Counter=-1;
        public new int Id { get; set; }
        public string Group_name{ get; set; }
        public Person Leader{ get; set; }
        public List<Student> Group_students = new List<Student>();
        public static List<Group> Groups = new List<Group>();
        //-------------------------------------------------------------------------------
        public Group(){
            Counter++;
            Id = Counter;
        }
        //-------------------------------------------------------------------------------
        public void Add_togroup(Student p1)
        {
            this.Group_students.Add(p1);
        }
        //-------------------------------------------------------------------------------
        public override string ToString()
        {
            return
                $"Факультет -   {Faculty_name}\nКафедра -   {Department_name}\nГруппа -   {Group_name}\nСтароста группы -   " +
                $"{Leader.Name}\nСписок студентов группы:  {Return_list(Group_students)}.";
        }
        //-------------------------------------------------------------------------------
        public static void Create_fac()
        {
            bool NotExist=true;
            Show_list(Faculties);
            Console.WriteLine("\nВведите название факультета:");
            string fac = Console.ReadLine();
            foreach (Faculty item in Faculties)
            {
                if (item.Faculty_name == fac)
                {
                    NotExist = false;
                    Console.WriteLine("Факультет уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if (NotExist == true)
            {
                var facc = new Faculty{Faculty_name=fac};
                Faculties.Add(facc);
                Console.WriteLine("------------------------Завершено!--------------------------");
            }
        }
        //-------------------------------------------------------------------------------
        public static void Create_dep()
        {
            bool NotExist = true;
            Show_list(Departments);
            Console.WriteLine("\nВведите название кафедры:");
            string caf = Console.ReadLine();
            foreach (Department VARIABLE in Departments)
            {
                if (VARIABLE.Department_name == caf)
                {                                
                    NotExist = false;
                    Console.WriteLine("Каферда уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if(NotExist==true)
            {
                Console.WriteLine("Кафедра принадлежит факультету(id):");
                Show_list(Faculties);
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nВведите имя главкафедры:");
                string glavcaf = Console.ReadLine();                              
                var glavcaff = new Teacher{Name=glavcaf};
                var caff = new Department{Department_name  = caf,Head = glavcaff};
                Departments.Add(caff);
                Faculties[id].Faculty_departments.Add(caff);
                Heads.Add(glavcaff);    
                Console.WriteLine("------------------------Завершено!--------------------------");
            }
        }    
        //-------------------------------------------------------------------------------
        public static void Create_group()
        {                 
            bool NotExist = true;
            Console.WriteLine("\nВведите название группы:");
            string gp = Console.ReadLine();
            foreach (Group VARIABLE in Groups)
            {
                if (VARIABLE.Group_name == gp)
                {
                    NotExist = false;
                    Console.WriteLine("Группа уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if (NotExist == true)
            {
                Console.WriteLine("Группа принадлежит кафедре(id):");
                Show_list(Departments);
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя старосты:");
                string star = Console.ReadLine();
                var starr = new Student{Name=star};
                var gpp = new Group{Group_name = gp,Leader = starr};
                Groups.Add(gpp);
                Departments[id].Department_groups.Add(gpp);
                Console.WriteLine("------------------------Завершено!--------------------------");
            }
        }
        //-------------------------------------------------------------------------------
        public static void Add_students()
        {
            bool NotExist = true;
            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();
            foreach (Student VARIABLE in Students)
            {
                if (VARIABLE.Name == name)
                {
                    NotExist = false;
                    Console.WriteLine("Студент уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if (NotExist == true)
            {
                var stud = new Student{Name=name};
                Students.Add(stud);
                Show_list(Groups);
                Console.WriteLine("В какую группу добавить?(id)");
                int id = Convert.ToInt32(Console.ReadLine());
                Groups[id].Group_students.Add(stud);
                Console.WriteLine("------------------------Завершено!--------------------------");
            }
        }
        //-------------------------------------------------------------------------------
    }
}