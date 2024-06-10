using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


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

        public string Name { get; set; }

        public int YearBirth { get; set; }

        public int Age
        {
            get => MaxYearB - YearBirth;
            set 
            {
                if (MinYearB > YearBirth && YearBirth > MaxYearB) 
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                      "The valid range is between {MinYearB} and {MaxYearB}.");

                }
            }
        }

        public string email
        { 
            set 
            {
                foreach (string s in EndEmail) 
                {
                    if (email.Contains(s) == true) break;
                    else email = "Error incorrect email";
                }
            }
            get => email;
        }


        //public string

        public override string ToString()
        {
            return "Id: " + Id + "\r\nName: " + Name + "\r\nYear of birth: " + YearBirth + "\r\nAge: " + Age + "\r\nEmail: " + email;
        }
    }

    public class User : Person
    {
        public double time;
        public double Time 
        { 
            get => Time = 0; 
            set => Time = value; 
        }

        public double money;
        public double Money
        {
            get => Money = 0;
            set => Money = value;
        }

        public override string ToString()
        {
            return base.ToString() + "\r\\nTime: " + time + "\r\\nMoney" + money;
        }
    }
}
