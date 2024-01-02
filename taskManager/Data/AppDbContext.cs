using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1ULGF16\\SQLEXPRESS;Initial Catalog = Task_manager2 ; Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTable>()
                .Property(u => u.Password)
                .IsRequired();
        }
    }

    
}
