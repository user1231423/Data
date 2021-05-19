using Data.Files.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Files
{
    public class FilesDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public FilesDbContext(DbContextOptions<FilesDbContext> options)
            : base(options)
        {
        }

        public DbSet<File> Files { get; set; }
    }
}
