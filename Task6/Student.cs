using System;
using System.Collections.Generic;

namespace Task6
{
    public class Student:Person
    {
        public new int Id { get; set; }
        public string Group_info { get; set; }
        public static List<Student> Students = new List<Student>();
        //-------------------------------------------------------------------------------
        public Student()
        { 
            
        }
        //-------------------------------------------------------------------------------

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
            }
        }
        
        public override string ToString()
        {
            return $"ФИО студента - {Name}, Группа - {Group_info}";
        }
    }
}