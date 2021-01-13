using ToDoList.Core.Entities;
using ToDoList.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace ToDoList.DataAccess.Concrete.EntityFramework
{
    public class ToDoListContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-D77PTSR\UGUR;Database=ToDoApp;Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }    
        public DbSet<Part> Parts { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserOperationClaim>()
                .HasKey(uoc => new { uoc.OperationClaimId,uoc.UserId});
            modelBuilder.Entity<UserOperationClaim>()
                .HasOne(uoc => uoc.User)
                .WithMany(u => u.UserOperationClaims)
                .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserOperationClaim>()
                .HasOne(uoc => uoc.OperationClaim)
                .WithMany(o => o.userOperationClaims)
                .HasForeignKey(o => o.OperationClaimId);          
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.RoleId, ur.UserId });
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(o => o.UserRoles)
                .HasForeignKey(o => o.RoleId);
        }
    }
}
