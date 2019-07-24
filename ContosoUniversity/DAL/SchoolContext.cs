using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        // The name of the connection string (which you'll add to the Web.config file later) 
        // is passed in to the constructor.
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        // prevents table names from being pluralized. If you didn't do this, the generated tables in the database would 
        // be named Students, Courses, and Enrollments. Instead, the table names will be Student, Course, and Enrollment. 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}