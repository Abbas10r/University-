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
        public Person(string Name,string Gender,string Passport,string Address)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Passport = Passport;
            this.Address = Address;
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