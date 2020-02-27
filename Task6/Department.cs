using System.Collections.Generic;
namespace Task6
{
    public class Department:Faculty
    {
        public string Department_name{ get; set; }
        public bool IsProfiling{ get; set; }
        public Teacher Head{ get; set; }
        public static List<Person> Heads = new List<Person>();
        public static List<Department> Departments = new List<Department>();
        public Department() {Departments.Add(this);}
        public Department(string faculty_name,string department_name, bool IsProfiling, Teacher Head):base(faculty_name)
        {   
            Department_name = department_name;
            this.IsProfiling = IsProfiling;
            this.Head = Head;
            Departments.Add(this);
        }
        public string Show_list(List<Person> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE}";
                st += stt;
            }
            return st;
        }
    }
}