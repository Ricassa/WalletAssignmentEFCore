using Microsoft.EntityFrameworkCore;
using System;

namespace Hubtel.Wallets.Api.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, RoleName = "User" },
                new Role { RoleID = 2, RoleName = "Admin" });

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "John Lee", Email = "john@lee.com", RoleID = 2 },
                new User { UserID = 2, UserName = "Sarah Ham", Email = "saray@ham.com", RoleID = 1 },
                new User { UserID = 3, UserName = "Mary Jes", Email = "mary@jes.com", RoleID = 1 },
                new User { UserID = 4, UserName = "Erica Ana", Email = "erica@ana.com", RoleID = 2 }
                );

            modelBuilder.Entity<Option>().HasData(
                new Option { PopID = 1, PopNumber = 1, PopComment = "Type", PopDesc = "Momo", PopEntryPerson = "Erica", PopSysDate = DateTime.Now },
                new Option { PopID = 2, PopNumber = 2, PopComment = "Type", PopDesc = "Card", PopEntryPerson = "Erica", PopSysDate = DateTime.Now },
                new Option { PopID = 3, PopNumber = 3, PopComment = "Account Scheme", PopDesc = "Visa", PopEntryPerson = "Erica", PopSysDate = DateTime.Now },
                new Option { PopID = 4, PopNumber = 4, PopComment = "Account Scheme", PopDesc = "Master Card", PopEntryPerson = "Erica", PopSysDate = DateTime.Now },
                new Option { PopID = 5, PopNumber = 5, PopComment = "Account Scheme", PopDesc = "MTN", PopEntryPerson = "Erica", PopSysDate = DateTime.Now },
                new Option { PopID = 6, PopNumber = 6, PopComment = "Account Scheme", PopDesc = "Vodafone", PopEntryPerson = "Erica", PopSysDate = DateTime.Now },
                new Option { PopID = 7, PopNumber = 7, PopComment = "Account Scheme", PopDesc = "AirtelTigo", PopEntryPerson = "Erica", PopSysDate = DateTime.Now });


            modelBuilder.Entity<Wallet>().HasData(
            new Wallet { ID = 1, Name = "John Lee", Type = "Momo", AccountNumber = "0242567894", AccountScheme = "MTN", Owner = "0242567894", UserID = 1, CreatedAt = DateTime.Now },
           new Wallet { ID = 2, Name = "John Lee", Type = "Momo", AccountNumber = "0506665432", AccountScheme = "Vodafone", Owner = "0554327654", UserID = 1, CreatedAt = DateTime.Now },
           new Wallet { ID = 3, Name = "John Lee", Type = "Card", AccountNumber = "467845", AccountScheme = "Visa", Owner = "0207654326", UserID = 1, CreatedAt = DateTime.Now },
           new Wallet { ID = 4, Name = "Sarah Ham", Type = "Momo", AccountNumber = "0207777775", AccountScheme = "Vodafone", Owner = "0206543276", UserID = 2, CreatedAt = DateTime.Now },
           new Wallet { ID = 5, Name = "Mary Jes", Type = "Card", AccountNumber = "234567", AccountScheme = "Visa", Owner = "0267654327", UserID = 3, CreatedAt = DateTime.Now },
           new Wallet { ID = 6, Name = "Sarah Ham", Type = "Momo", AccountNumber = "0275676548", AccountScheme = "AirtelTigo", Owner = "0267265438", UserID = 2, CreatedAt = DateTime.Now },
           new Wallet { ID = 7, Name = "Erica Ana", Type = "Card", AccountNumber = "999654", AccountScheme = "Master Card", Owner = "0579876543", UserID = 4, CreatedAt = DateTime.Now }


            );
        }
    }
}
