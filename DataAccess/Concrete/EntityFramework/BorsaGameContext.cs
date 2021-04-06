using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class BorsaGameContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BorsaGame;Trusted_Connection=true");
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAsset> AccountAssets { get; set; }
        public DbSet<AccountFinance > AccountFinances { get; set; }
        public DbSet<AccountInformation> AccountInformations { get; set; }
    }
}
