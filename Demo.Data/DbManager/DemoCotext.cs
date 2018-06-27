using Demo.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.DbManager
{
    public class DemoCotext:DbContext
    {
        public DemoCotext(DbContextOptions<DemoCotext> options)
     : base(options) { }
       
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Project> Project { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
