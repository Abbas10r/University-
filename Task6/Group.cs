using System;
using System.Collections.Generic;

namespace Task6
{
    public class Group:Cafedra
    {
        public string Group_name{ get; set; }
        public Person Starosta{ get; set; }
        public List<Person> Students_list = new List<Person>();
        public Group(){}
        public Group(string fname,string cname,bool isProfilir, Teacher glavcaferdy,string name,Student person):base(fname,cname,isProfilir,glavcaferdy)
        {
            Group_name = name;
            this.Starosta = person;
            this.Students_list.Add(person);
        }

        public void Add_students(Person p1)
        {
            this.Students_list.Add(p1);
        }

        public string Show_list(List<Person> Students_list)
        {
            string st = "", stt = "";
            foreach (var VARIABLE in Students_list)
            {
                stt = $"  {VARIABLE}";
                st += stt;
            }
            return st;
        }
        public override string ToString()
        {
            return $"Факультет -   {Faculty_name}\nКафедра -   {Cafedra_name}\nГруппа -   {Group_name}\nСтароста группы -   " +
                   $"{Starosta}\nСписок студентов группы:  {Show_list(Students_list)}.";
            
        }
    }
}