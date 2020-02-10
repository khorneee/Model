using ConsoleApp8.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class ERPDbContext : DbContext
    {
        /// <summary>
        /// dotnet ef  migrations add Initial -o Migrations
        /// </summary>
        public ERPDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentPropertiesContainer> ComponentPropertiesContainer { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyValues> PropertyValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Container>()
                .HasKey(o => o.IdContainer);

            modelBuilder.Entity<Entity>()
                .HasKey(o => o.IdEntity);

            modelBuilder.Entity<Component>()
                .HasKey(o => o.IdComponent);

            modelBuilder.Entity<ComponentPropertiesContainer>()
                .HasKey(o => new { o.IdComponent, o.IdContainer, o.IdProperty  });

            modelBuilder.Entity<Entity>()
                .HasKey(o => new { o.IdEntity });


            modelBuilder.Entity<Property>()
                .HasKey(o => new { o.IdEntity, o.IdProperty });


            modelBuilder.Entity<PropertyValues>()
                .HasKey(o => new { o.IdProperty,  });

            base.OnModelCreating(modelBuilder);
        }

        public class DesignTimeActivitiesDbContextFactory : IDesignTimeDbContextFactory<ERPDbContext>
        {
            public ERPDbContext CreateDbContext(string[] args)
            {
                DbContextOptionsBuilder<ERPDbContext> builder = new DbContextOptionsBuilder<ERPDbContext>();

                var context = new ERPDbContext(
                    builder
                    .UseSqlServer("Server=localhost;Database=ERP;User Id=sa;Password=Str0ngPassword;")
                    .Options);

                return context;
            }
        }
    }
}
