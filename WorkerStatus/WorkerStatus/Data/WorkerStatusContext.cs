using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkerStatus.Models;

namespace WorkerStatus.Data
{
    public class WorkerStatusContext : DbContext
    {
        public WorkerStatusContext (DbContextOptions<WorkerStatusContext> options)
            : base(options)
        {
        }

        public DbSet<WorkerStatus.Models.Person> Person { get; set; } //= default!;
    }
}
