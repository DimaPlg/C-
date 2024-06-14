/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/

using Microsoft.EntityFrameworkCore;
using static Persons;
using System;
using static bank.DbCore.DbReserch;
using bank.DataModifMethDb;

namespace bank 
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string[] yn = { "yes", "no" };
            using (ApplicationContext db = new ApplicationContext()) 
            {
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (ApplicationContext db = new ApplicationContext()) 
            {
                var users = db.Users.ToList();
                foreach (User u in users) 
                {
                    Console.WriteLine($"Do yuo want to change user name: {u.Name}?");
                    string key = Console.ReadLine();
                    key = chekInputYesNo.chekYesNo(key, yn);
                    if (key == "yes") 
                    {
                        Console.WriteLine("Write new name: ");
                        u.Name = Console.ReadLine();
                        db.SaveChanges();
                    }
                    
                }

                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }

                foreach (User u in users)
                {
                    db.Users.Remove(u);
                    db.SaveChanges();
                }
            }

            using (ApplicationContext db = new ApplicationContext()) 
            {
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }

    }
}
