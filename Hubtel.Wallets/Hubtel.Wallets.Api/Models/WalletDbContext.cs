using Microsoft.EntityFrameworkCore;
using System;

namespace Hubtel.Wallets.Api.Models
{
    //WalletDBContext derives from DBContext(used to interact with our DB) 
    public class WalletDbContext : DbContext
    {
        //DbContextOptions(has configuration information like connection string to use,the database provider to
        //use,etc hence we create a constructor of our class WalletDbContext and pass an instance of the
        //DbContextOptions to it as a parameter
        public WalletDbContext(DbContextOptions<WalletDbContext> options)
            : base(options)
        {

        }

        //Used to Create and Query Entities in our underlying db
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Option> Options { get; set; }

        //Used to add Initial Data(specified in ModelBuilderExtensions.cs) to our DB 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
