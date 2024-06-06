using System;


namespace reterned.class_1
{
    public abstract class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int YearBorn { get; set; }

        public void Print () 
        {
            Console.WriteLine ($"Id: {Id} \r\nName: {Name} \r\nAge: {2024 - YearBorn}");
        }
    }
    public class User : Persons  
    {
        public double Time { get; set; }
        public double Money { get; set; }


    }
}
