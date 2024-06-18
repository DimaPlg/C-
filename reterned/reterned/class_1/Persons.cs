using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;


namespace reterned.class_1
{
    internal class Persons
    {
        
    }

    public abstract class Person 
    {
        private int MinYearB = 1907;

        private int MaxYearB = 2024;

        private List<string> EndEmail = new List<string>() { "@gmail.com" , "@yandex.by", "@mail.ru" , "admin"};

        public int Id { get; set; }

        [property: Required]
        [property: StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [property: Range(1907, 2024)]
        public int YearBirth { get; set; }


        /* public string email
         {
             get => email;
             set 
             {
                 foreach (string s in EndEmail) 
                 {
                     if (email.Contains(s) == true) break;
                     else email = "Error incorrect email";
                 }
             }

         }*/


        //public string


        public override string ToString()
        {
            return "Id: " + Id + "\r\nName: " + Name + "\r\nYear of birth: " + YearBirth + "\r\nAge: " + (MaxYearB - YearBirth) + "\r\nEmail: ";// email;
        }
    }

    public class User : Person
    {
        public double time;
        public double Time 
        { 
            get; 
            set; 
        }

        public double money;

        public double Money
        {
            get;
            set;
        }


        public override string ToString()
        {
            return base.ToString() + "\r\\nTime: " + time + "\r\\nMoney" + money;
        }
    }
}
