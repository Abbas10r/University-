using System.Collections.Generic;
using static Task6.Department;
namespace Task6
{
    public class Faculty
    {
        private static int Counter=-1;
        public int Id { get; set; }
        public string Faculty_name { get; set; }
        public List<Department> Faculty_departments = new List<Department>();
        public static List<Faculty> Faculties = new List<Faculty>();
        //-------------------------------------------------------------------------------
        public Faculty()
        {
            Faculties.Add(this);
            Counter++;
            Id = Counter;
        }
        /*public Faculty(string faculty_name)
        {
            Counter++;
            Id = Counter;
            Faculty_name = faculty_name;
            Faculties.Add(this);
        }*/
        //-------------------------------------------------------------------------------
        public override string ToString()
        {
            return $"Название факультета - {Faculty_name}, Кафедры факультета - {Return_list(Faculty_departments)}";
        }
    }
}