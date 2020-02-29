using System;
using System.Collections.Generic;

namespace Task6
{
    public class Teacher:Person
    {
        public new int Id { get; set; }
        public string Department_info { get; set; }
        public string Position_info { get; set; }
        public static List<Teacher> Teachers = new List<Teacher>();
        //-------------------------------------------------------------------------------
        public Teacher()
        {
        }
        public override string ToString()
        {
            return $"ФИО учителя - {Name}, Предмет преподавания - {Position_info}";
        }
    }
}