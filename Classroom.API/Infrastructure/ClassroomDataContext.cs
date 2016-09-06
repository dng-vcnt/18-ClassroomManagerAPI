using Classroom.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Classroom.API.Infrastructure
{
    public class ClassroomDataContext : DbContext
    {
        public ClassroomDataContext() : base("ClassroomManager")
        {

        }

        public IDbSet<Assignment> Assignments { get; set; }
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Compound Key
            modelBuilder.Entity<Assignment>()
                        .HasKey(a => new { a.StudentId, a.ProjectId });

            // A project has many assignments
            modelBuilder.Entity<Project>()
                        .HasMany(p => p.Assignments)
                        .WithRequired(a => a.Projects)
                        .HasForeignKey(a => a.ProjectId);

            // A student has many assignments
            modelBuilder.Entity<Student>()
                        .HasMany(s => s.Assignments)
                        .WithRequired(a => a.Students)
                        .HasForeignKey(a => a.StudentId);
        }
    }
}