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