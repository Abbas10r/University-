using System;
using System.Collections.Generic;

namespace Task6
{
    public class Student:Person
    {
        private static int Counter=-1;
        public int Id { get; set; }
        public string Group_info { get; set; }
        public static List<Student> Students = new List<Student>();
        //-------------------------------------------------------------------------------
        public Student(){ Students.Add(this);
            Counter++;
            Id = Counter;
        }
    }
}