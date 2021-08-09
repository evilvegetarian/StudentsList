using Microsoft.EntityFrameworkCore;
using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    public class StudentGroupContext : DbContext
    {
        public DbSet<Group> Groups{ get; set; }

        public DbSet<Student> Students{ get; set; }

        public StudentGroupContext( DbContextOptions<StudentGroupContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
