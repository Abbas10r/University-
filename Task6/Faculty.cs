using System;
using System.Collections.Generic;
using static Task6.Department;
namespace Task6
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Faculty_name { get; set; }
        public List<Department> Faculty_departments = new List<Department>();
        public static List<Faculty> Faculties = new List<Faculty>();
        //-------------------------------------------------------------------------------
        public Faculty() { }
        //-------------------------------------------------------------------------------
        public override string ToString()
        {
            return $"Название факультета - {Faculty_name}, Кафедры факультета - {Return_list(Faculty_departments)}";
        }
        public void Show_info()
        {
            Console.WriteLine(this.ToString());
        }
    }
}