using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSample.DbModels
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<IdCard> IdCards { get; set; }
    }
    
}