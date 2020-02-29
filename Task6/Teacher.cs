using System;
using System.Collections.Generic;

namespace Task6
{
    public class Teacher:Person
    {
        public new int Id { get; set; }
        public string Department_info { get; set; }
        public string Position_info { get; set; }
        public static List<Teacher> Teachers = new List<Teacher>();
        //-------------------------------------------------------------------------------
        public Teacher()
        {
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
            }
        }
        //-------------------------------------------------------------------------------
        public override string ToString()
        {
            return $"ФИО учителя - {Name}, Предмет преподавания - {Position_info}";
        }
    }
}