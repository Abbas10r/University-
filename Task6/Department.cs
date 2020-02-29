using System;
using System.Collections.Generic;
using static Task6.Faculty;
namespace Task6
{
    public class Department:Faculty
    {
        public new int Id { get; set; }
        public string Department_name{ get; set; }
        public bool IsProfiling{ get; set; }
        public Teacher Head{ get; set; }
        public List<Group> Department_groups = new List<Group>();
        public static List<Person> Heads = new List<Person>();
        public static List<Department> Departments = new List<Department>();
        //-------------------------------------------------------------------------------
        public Department() {}
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Student> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Name}\n";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Student> list)
        {
            Console.WriteLine($"--------------Имеются: {Return_list(list)}");
            Console.WriteLine("------------------------Завершено!--------------------------");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Teacher> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Name}\n";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Teacher> list)
        {
            Console.WriteLine($"--------------Имеются: {Return_list(list)}");
            Console.WriteLine("------------------------Завершено!--------------------------");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Faculty> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $" {VARIABLE.Id} - {VARIABLE.Faculty_name}\n";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Faculty> list)
        {
            Console.WriteLine($"--------------Имеются: {Return_list(list)}");
            Console.WriteLine("------------------------Завершено!--------------------------");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Group> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Group_name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Group> list)
        {
            Console.WriteLine($"--------------Имеются: {Return_list(list)}");
            Console.WriteLine("------------------------Завершено!--------------------------");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Department> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Department_name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Department> list)
        {
            Console.WriteLine($"--------------Имеются: {Return_list(list)}");
            Console.WriteLine("------------------------Завершено!--------------------------");
        }

        public override string ToString()
        {
            return $"Название факультета - {Faculty_name}, Название кафедры - {Department_name}, Глава кафедры - {Head}, Группы кафедры - {Return_list(Department_groups)}";
        }
    }
}