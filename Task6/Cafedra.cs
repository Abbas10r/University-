namespace Task6
{
    public class Cafedra:Faculty
    {
        public string Cafedra_name{ get; set; }
        public bool IsProfilir{ get; set; }
        public Teacher Glavcaferdy{ get; set; }
        public Cafedra() {}
        public Cafedra(string fname,string cname, bool isProfilir, Teacher glavcaferdy):base(fname)
        {   
            Cafedra_name = cname;
            IsProfilir = isProfilir;
            Glavcaferdy = glavcaferdy;
        }
    }
}