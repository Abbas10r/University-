using System;
using System.Collections.Generic;

namespace Task6
{
    public class Teacher:Person
    {
        private static int Counter=-1;
        public int Id { get; set; }
        public string Department_info { get; set; }
        public string Position_info { get; set; }
        public static List<Teacher> Teachers = new List<Teacher>();
        //-------------------------------------------------------------------------------
        public Teacher(){Teachers.Add(this);
            Counter++;
            Id = Counter;
        }
    }
}