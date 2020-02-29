using System;
using System.Collections.Generic;
using System.Linq;
using static Task6.Faculty;
using static Task6.Department;
using static Task6.Student;
using static Task6.Teacher;
using static Task6.Group;
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsOn = true;
            int button = 0;
            Console.WriteLine("           Добро пожаловать в шарагу!");
            Console.WriteLine("-------------------------------------------------");
            while (IsOn)
            {
                Console.WriteLine("   Нажмите 1 чтобы добавить факультет" +
                                  "\n   Нажмите 2 чтобы добавить кафедру"+
                                  "\n   Нажмите 3 чтобы добавить группу"+
                                  "\n   Нажмите 4 чтобы добавить студента"+
                                  "\n   Нажмите 5 чтобы добавить преподавателя"+
                                  "\n   Нажмите 6 чтобы увидеть отдельные списки: "+
                                  //"\n   Нажмите 7 чтобы получить более подробную инф."+
                                  "\n   Нажмите 0 чтобы завершить программу.");
                button = Convert.ToInt32(Console.ReadLine());
                switch (button)
                {
                    case 0:
                        IsOn = false;
                        break;
                    case 1:
                        Create_fac();
                        break;
                    case 2:
                        Checker_dep();
                        break;
                    case 3:
                        Checker_gr();
                        break;
                    case 4:
                        Checker_stud();
                        break;
                    case 5:
                        Add_teacher();
                        break;
                    case 6:
                        Show_lists();
                        break;
                    case 7:
                        break;
                }
            }
        }
    }
}