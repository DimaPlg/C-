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
            List<Persons> list = new List<Persons>(InputMethodForList.InputList());
            foreach (Persons person in list)
            {
                person.Print();
            }
        }
        
    }
}
