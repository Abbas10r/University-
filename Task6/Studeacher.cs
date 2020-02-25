namespace Task6
{
    public class Studeacher:Student
    {
        public string Cafedra_info { get; set; }
        public string Position_info { get; set; }
        public Studeacher(){}

        public Studeacher(string Name,string Gender,int i,string Id,string Address,string Group_Info,string cafedraInfo,string positionInfo) : base(Name,Gender,i,Id,Address,Group_Info)
        {
            Cafedra_info = cafedraInfo;
            Position_info = positionInfo;
        }
    }
}