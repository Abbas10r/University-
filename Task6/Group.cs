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
        public Group(string fname,string cname,bool isProfilir, Person glavcaferdy,string name,Person person):base(fname,cname,isProfilir,glavcaferdy)
        {
            Group_name = name;
            this.Starosta = person;
            this.Students_list.Add(person);
        }

        public void Add_students(Person p1)
        {
            this.Students_list.Add(p1);
        }

        public void Show_list()
        {
            foreach (Person item in Students_list)
            {
                Console.WriteLine(item+" ");
            }
        }
        public override string ToString()
        {
            return $"Факультет -   {Faculty_name}\nКафедра -   {Cafedra_name}\nГруппа -   {Group_name}\nСтароста группы -   " +
                   $"{Starosta}\nСписок студентов группы -   ";//TODO remake
        }
    }
}