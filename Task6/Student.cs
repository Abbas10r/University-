using System;
using System.Collections.Generic;

namespace Task6
{
    public class Student:Person
    {
        public string Group_info { get; set; }
        public static List<Student> Students = new List<Student>();
        public Student(){ Students.Add(this);}
        public Student(string Name,string Gender,string Id,string Address,string Group_Info):base(Name,Gender,Id,Address)
        {
            this.Group_info = Group_info;
            Students.Add(this);
        }
    }
}