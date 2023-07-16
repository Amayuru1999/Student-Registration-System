
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project
{
    public class DataBaseContext : DbContext
    {
        public readonly string Path = @"D:\New folder\student_database1.db";
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={Path}");
        }
        public DbSet<Student> Students
        {
            get; set;
        }
        public DbSet<StudentDetails> StudentDetailsFor
        {
            get; set;
        }
        public DbSet<Administrator> Administrators {
            get; set; 
        }
        public DbSet<Module> Modules
        {
            get;set;
        }
    }
}
