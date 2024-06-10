using reterned.class_1;
using reterned.Methods;
using System;
using System.Collections.Generic;

namespace reterned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> list = new List<User>(InputMethodForList.ToList());
            foreach (User person in list)
            {
                Console.WriteLine(person.email);
            }
        }
        
    }
}
