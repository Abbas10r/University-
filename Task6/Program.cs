using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Glavcaf = new Person{Name = "Десяткой Юрий Петрович"};
            var Starosta = new Person{Name = "Шевченко Филипп"};
            var Group = new Group("Естественно-Технический факультет","Информационные и вычислительные технологии"
                ,true,Glavcaf,"ЕПИ-1-17",Starosta);
            Group.Students_list.Add(Starosta);
            Console.WriteLine(Group.ToString());
        }
    }
}