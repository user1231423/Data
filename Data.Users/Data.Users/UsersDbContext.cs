using Data.Users.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Users
{
    public class UsersDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Users
        /// </summary>
        public DbSet<UserDAO> Users { get; set; }

        /// <summary>
        /// On configuring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configs
        }

        /// <summary>
        /// On Model configuration
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDAO>()
                .Property(x => x.CreateDate)
                .ValueGeneratedOnAdd(); 
            
            modelBuilder.Entity<UserDAO>()
                .Property(x => x.UpdateDate)
                .ValueGeneratedOnUpdate();
        }
    }
}
