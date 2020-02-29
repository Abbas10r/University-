using System;
using System.Collections.Generic;
namespace Task6
{
    public class Person{
        public string Name{ get; set; }
        public string Gender{ get; set; }
        public string Passport{ get; set; }
        public string Address{ get; set; }
        //-------------------------------------------------------------------------------
        public Person()
        {
           
        }
        //-------------------------------------------------------------------------------
        public static string Return_list<T>(List<T> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE}";
                st += stt;
            }
            return st;
        }
        public static void Show_list<T>(List<T> list)
        {
            Console.WriteLine($"Уже имеются: {Return_list(list)}");
        }
    }
}