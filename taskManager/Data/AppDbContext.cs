using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using taskManager.Data; 

namespace taskManager.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<UserTable> users { get; set; } 
        public DbSet<Task>  tasks { get; set; }
        public DbSet<History> histroies {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }

    
}
