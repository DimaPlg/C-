﻿using reterned.class_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reterned.Methods
{
    public static class InputMethodForList
    {
        public static List<Persons> InputList() 
        {
            List<Persons> list = new List<Persons>();

            bool res = true;

            while (res == true)
            {
                Persons person = new Persons();
          
                Console.WriteLine("Input Id: ");
                person.Id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input Name: ");
                person.Name = Console.ReadLine();

                Console.WriteLine("Year of born: ");
                person.YearBorn = Int32.Parse(Console.ReadLine());
                
                list.Add(person);

                Console.WriteLine(("Do yoy want to end? \r\n if yes input - 1 \r\n else input what you want"));
                string resalt = Console.ReadLine();
                if (resalt == "1") res = false;
            }
            return list;
        }
    }
}
