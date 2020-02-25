namespace Task6
{
    public class Student:Person
    {
        public string Group_info { get; set; }

        public Student(){}

        public Student(string Name,string Gender,int i,string Id,string Address,string Group_Info):base(Name,Gender,i,Id,Address)
        {
            this.Group_info = Group_info;
        }
    }
}