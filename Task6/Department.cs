using System;
using System.Collections.Generic;
using static Task6.Faculty;
using static Task6.Teacher;
namespace Task6
{
    public class Department:Faculty
    {
        public new int Id { get; set; }
        public string Department_name{ get; set; }
        public bool IsProfiling{ get; set; }
        public Teacher Head{ get; set; }
        public List<Group> Department_groups = new List<Group>();
        public static List<Person> Heads = new List<Person>();
        public static List<Department> Departments = new List<Department>();
        //-------------------------------------------------------------------------------
        public Department() {}
        //-------------------------------------------------------------------------------
        public static void Checker_dep()
        {
            if (Faculties.Count == 0)
            {
                Console.WriteLine("--------------Сначала нужно добавить факультет!");
            }
            else
            {
                Create_dep();
            }
        }
        //-------------------------------------------------------------------------------
        public static void Create_dep()
        {
            bool NotExist = true;
            Show_list(Departments);
            Console.WriteLine("\nВведите название кафедры:");
            string caf = Console.ReadLine();
            foreach (Department VARIABLE in Departments)
            {
                if (VARIABLE.Department_name == caf)
                {                                
                    NotExist = false;
                    Console.WriteLine("--------------Каферда уже существует!");
                }
                else
                {
                    NotExist = true;
                }
            }
            if(NotExist==true)
            {
                Console.WriteLine("Кафедра принадлежит факультету(id):");
                Show_list(Faculties);
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nВведите имя главкафедры:");
                string glavcaf = Console.ReadLine();                              
                var glavcaff = new Teacher{Name=glavcaf};
                Teachers.Add(glavcaff);
                glavcaff.Id = Teachers.IndexOf(glavcaff);
                var caff = new Department{Faculty_name = Faculties[id].Faculty_name,Department_name  = caf,Head = glavcaff};
                Departments.Add(caff);
                caff.Id = Departments.IndexOf(caff);
                Faculties[id].Faculty_departments.Add(caff);
                Heads.Add(glavcaff);    
            }
        }   
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Student> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Student> list)
        {
            Console.WriteLine($"Имеются: {Return_list(list)}");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Teacher> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Teacher> list)
        {
            Console.WriteLine($"-Имеются: {Return_list(list)}");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Faculty> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $" {VARIABLE.Id} - {VARIABLE.Faculty_name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Faculty> list)
        {
            Console.WriteLine($"Имеются: {Return_list(list)}");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Group> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Group_name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Group> list)
        {
            Console.WriteLine($"Имеются: {Return_list(list)}");
        }
        //-------------------------------------------------------------------------------
        public static string Return_list(List<Department> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE.Id} - {VARIABLE.Department_name}";
                st += stt;
            }
            return st;
        }
        public static void Show_list(List<Department> list)
        {
            Console.WriteLine($"Имеются: {Return_list(list)}");
        }

        public override string ToString()
        {
            return $"Название факультета - {Faculty_name}, Название кафедры - {Department_name}, Глава кафедры - {Head}, Группы кафедры - {Return_list(Department_groups)}";
        }
    }
}