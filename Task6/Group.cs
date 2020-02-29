using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static Task6.Faculty;
using static Task6.Department;
using static Task6.Student;
using static Task6.Group;
using static Task6.Teacher;
namespace Task6
{
    public class Group:Department
    {
        public new int Id { get; set; }
        public string Group_name{ get; set; }
        public Person Leader{ get; set; }
        public List<Student> Group_students = new List<Student>();
        public static List<Group> Groups = new List<Group>();
        //-------------------------------------------------------------------------------
        public Group(){ }
        //-------------------------------------------------------------------------------
        public static void Checker_dep()
        {
            if (Faculties.Count == 0)
            {
                Console.WriteLine("--------------Сначала нужно добавить факультет!");
            }
            else
            {
                Create_dep();
            }
        }
        public static void Checker_gr()
        {
            if (Departments.Count == 0)
            {
                Console.WriteLine("--------------Сначала нужно добавить кафедру!");
            }
            else
            {
                Create_group();
            }
        }
        public static void Checker_stud()
        {
            if (Groups.Count == 0)
            {
                Console.WriteLine("--------------Сначала нужно добавить группу!");
            }
            else
            {
                Add_students();
            }
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
                    Console.WriteLine("--------------Факультет уже существует!");
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
                facc.Id=Faculties.IndexOf(facc);
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
                    Console.WriteLine("--------------Каферда уже существует!");
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
                Teachers.Add(glavcaff);
                glavcaff.Id = Teachers.IndexOf(glavcaff);
                var caff = new Department{Faculty_name = Faculties[id].Faculty_name,Department_name  = caf,Head = glavcaff};
                Departments.Add(caff);
                caff.Id = Departments.IndexOf(caff);
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
                    Console.WriteLine("--------------Группа уже существует!");
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
                Students.Add(starr);
                starr.Id = Students.IndexOf(starr);
                var gpp = new Group{Department_name = Departments[id].Department_name,Group_name = gp,Leader = starr};
                Groups.Add(gpp);
                gpp.Id = Groups.IndexOf(gpp);
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
                    Console.WriteLine("--------------Студент уже существует!");
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
                stud.Id = Students.IndexOf(stud);
                Show_list(Groups);
                Console.WriteLine("В какую группу добавить?(id)");
                int id = Convert.ToInt32(Console.ReadLine());
                Groups[id].Group_students.Add(stud);
                stud.Group_info = Groups[id].Group_name;
                Console.WriteLine("------------------------Завершено!--------------------------");
            }
        }
        //-------------------------------------------------------------------------------
        public static void Add_teacher()
        {
            bool NotExist = true;
            Console.WriteLine("Введите имя учителя:");
            string name = Console.ReadLine();
            foreach (Teacher VARIABLE in Teachers)
            {
                if (VARIABLE.Name == name)
                {
                    NotExist = false;
                    Console.WriteLine("--------------Учитель уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if (NotExist == true)
            {
                Console.WriteLine("Предмет преподавания: ");
                string subject = Console.ReadLine();
                var tech = new Teacher{Name=name,Position_info = subject};
                Teachers.Add(tech);
                tech.Id = Teachers.IndexOf(tech);
                Console.WriteLine("------------------------Завершено!--------------------------");
            }
        }
        //-------------------------------------------------------------------------------
        public static void Show_lists()
        {
            Console.WriteLine("Вывести список: \n1 - Факультетов\n2 - Кафедр\n3 - Групп\n4 - Студентов\n5 - Учителей");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Show_list(Faculties);
                    break;
                case 2:
                    Show_list(Departments);
                    break;
                case 3:
                    Show_list(Groups);
                    break;
                case 4:
                    Show_list(Students);
                    break;
                case 5:
                    Show_list(Teachers);
                    break;
            }
        }
        //-------------------------------------------------------------------------------
        public override string ToString()
        {
            return
                $"Факультет -   {Faculty_name}\nКафедра -   {Department_name}\nГруппа -   {Group_name}\nСтароста группы -   " +
                $"{Leader.Name}\nСписок студентов группы:  {Return_list(Group_students)}.";
        }
        //-------------------------------------------------------------------------------
    }
}