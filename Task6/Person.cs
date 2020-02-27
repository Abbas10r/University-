using System;
using System.Collections.Generic;
namespace Task6
{
    public class Person{
        public string Name{ get; set; }
        public string Gender{ get; set; }
        public string Id{ get; set; }
        public string Address{ get; set; }

        public Person()
        {
           
        }
        public Person(string Name,string Gender,string Id,string Address)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Id = Id;
            this.Address = Address;
        }
        public static string Show_list(List<Person> list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in list)
            {
                stt = $"  {VARIABLE}";
                st += stt;
            }
            return st;
        }
    }
}