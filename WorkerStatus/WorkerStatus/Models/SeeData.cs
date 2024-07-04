using Microsoft.EntityFrameworkCore;
using WorkerStatus.Data;

namespace WorkerStatus.Models
{
    public static class SeeData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WorkerStatusContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WorkerStatusContext>>()))
            {
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }
                context.Person.AddRange(
                    new Person
                    {
                        Name = "Kendy",
                        Surname = "Livetrou",
                        Patronymic = "Green",
                        Age = 32,
                        Position = "Manager",
                        Team = "Sale",
                        HourlyRate = 6.7M
                    },

                    new Person
                    {
                        Name = "Mike",
                        Surname = "Trous",
                        Patronymic = "Klip",
                        Age = 37,
                        Position = "Developer",
                        Team = "IT",
                        HourlyRate = 9.7M
                    },

                    new Person
                    {
                        Name = "Mihail",
                        Surname = "Pechenkin",
                        Patronymic = "Leonidovich",
                        Age = 29,
                        Position = "Recrutor",
                        Team = "Sale",
                        HourlyRate = 6.7M
                    }
                );

                context.SaveChanges();

            }
        }
    }
}
