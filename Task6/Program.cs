using System;
using System.Collections.Generic;
using System.Linq;
using static Task6.Department;
using static Task6.Student;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var studik = new Student{Name="Abbas"};
            var studikk = new Student{Name="Egor"};
            var gr = new Group{Group_name  = "Epi",Leader = studik};
            gr.Add_togroup(studikk);
            gr.Add_togroup(studik);
            Console.WriteLine(gr.ToString());
            Show_list(Students);
        }
    }
}