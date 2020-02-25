namespace Task6
{
    public class Teacher:Person
    {
        public string Cafedra_info { get; set; }
        public string Position_info { get; set; }
        public Teacher(){}

        public Teacher(string Name,string Gender,int i,string Id,string Address,string cafedraInfo,string positionInfo):base(Name,Gender,i,Id,Address)
        {
            Cafedra_info = cafedraInfo;
            Position_info = positionInfo;
        }
    }
}