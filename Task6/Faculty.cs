using System;
using System.Collections.Generic;
using static Task6.Department;
namespace Task6
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Faculty_name { get; set; }
        public List<Department> Faculty_departments = new List<Department>();
        public static List<Faculty> Faculties = new List<Faculty>();
        //-------------------------------------------------------------------------------
        public Faculty() { }
        //-------------------------------------------------------------------------------
        public static void Create_fac()
        {
            bool NotExist=true;
            Show_list(Faculties);
            Console.WriteLine("\nВведите название факультета:");
            string fac = Console.ReadLine();
            foreach (Faculty item in Faculties)
            {
                if (item.Faculty_name == fac)
                {
                    NotExist = false;
                    Console.WriteLine("--------------Факультет уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if (NotExist == true)
            {
                var facc = new Faculty{Faculty_name=fac};
                Faculties.Add(facc);
                facc.Id=Faculties.IndexOf(facc);
            }
        }
        public override string ToString()
        {
            return $"Название факультета - {Faculty_name}, Кафедры факультета - {Return_list(Faculty_departments)}";
        }
        public void Show_info()
        {
            Console.WriteLine(this.ToString());
        }
    }
}