using System;
using System.Collections.Generic;
using System.Linq;
using static Task6.Faculty;
using static Task6.Department;
using static Task6.Student;
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
                                  //"\n   Нажмите 5 чтобы добавить преподавателя"+
                                  //"\n   Нажмите 6 чтобы осмотреть факультет"+
                                  //"\n   Нажмите 7 чтобы осмотреть кафедру"+
                                  //"\n   Нажмите 8 чтобы осмотреть группу"+
                                  //"\n   Нажмите 9 чтобы осмотреть студента"+
                                  //"\n   Нажмите 10 чтобы осмотреть преподавателя"+
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
                        Create_dep();
                        break;
                    case 3:
                        Create_group();
                        break;
                    case 4:
                        Add_students();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                }
            }
        }
    }
}