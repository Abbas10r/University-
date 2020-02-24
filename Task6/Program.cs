using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Glavcaf = new Person{Name = "Десяткой Юрий Петрович"};
            var Starosta = new Person{Name = "Шевченко Филипп"};
            var Studik = new Person {Name = "Аббас Азисов"};
            var Group = new Group("Естественно-Технический факультет","Информационные и вычислительные технологии"
                ,true,Glavcaf,"ЕПИ-1-17",Starosta);
            Group.Students_list.Add(Studik);
            Group.Students_list.Add(new Person{Name="Нурсултан Кудайбергенов"});
            Console.WriteLine(Group.ToString());
        }
    }
}