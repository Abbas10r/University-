using System;
using System.Collections.Generic;

namespace Task6
{
    public class Teacher:Person
    {
        public string Department_info { get; set; }
        public string Position_info { get; set; }
        public static List<Teacher> Teachers = new List<Teacher>();
        public Teacher(){Teachers.Add(this);}

        public Teacher(string Name,string Gender,string Id,string Address,string cafedraInfo,string positionInfo):base(Name,Gender,Id,Address)
        {
            Department_info = cafedraInfo;
            Position_info = positionInfo;
            Teachers.Add(this);
        }
    }
}