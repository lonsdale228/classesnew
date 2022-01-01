using System;

namespace classesnew
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            Person p = new Person("Пупкин", "Вася");
            //p.Name = "Вася";
            //p.SecondName = "Пупкин";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.SecondName);



            Console.ReadLine();
        }
    }
}
