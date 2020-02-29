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

        public override string ToString()
        {
            return $"ФИО студента - {Name}, Группа - {Group_info}";
        }
    }
}