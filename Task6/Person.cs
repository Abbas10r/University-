using System;

namespace Task6
{
    public class Person
    {
        public string Name{ get; set; }
        public string Gender{ get; set; }
        public enum Position
        {
            Teacher,
            Student
        }
        public string Id{ get; set; }
        public string Address{ get; set; }

        public Person()
        {
            
        }
        public Person(string Name,string Gender,int i,string Id,string Address)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Id = Id;
            this.Address = Address;
        }
        public override string ToString()
        {
            return Name;//Remake it
        }
    }
}