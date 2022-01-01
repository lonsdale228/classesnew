using System;

namespace classesnew
{
    public class Person
    {
        public string SecondName { get; set; }
        public string Name { get; private set; }

        public Person(string secondName, string name)
        {

            SecondName = secondName;
            Name = name;
        }
            


        //public string Fullname
        //{
        //    get
        //    {
        //        return SecondName + " " + Name;
        //    }
        //}

        //public string ShortName
        //{
        //    get
        //    {
        //        return $"{SecondName} {Name.Substring(0, 1)}.";
        //    }
        //}
    }
}
