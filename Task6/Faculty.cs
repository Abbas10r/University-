using System.Collections.Generic;
namespace Task6
{
    public class Faculty
    {
        public string Faculty_name { get; set; }
        public static List<Faculty> Faculties = new List<Faculty>();
        public Faculty(){Faculties.Add(this);}
        public Faculty(string faculty_name)
        {
            Faculty_name = faculty_name;
            Faculties.Add(this);
        }
    }
}