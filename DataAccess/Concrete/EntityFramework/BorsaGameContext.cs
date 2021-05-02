using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{ 
    public class BorsaGameContext:DbContext
    {
        // SQL Bağlantı tanımlanması.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BorsaGame;Trusted_Connection=true");
        }
        // SQL Tabloları Nesnelerinin tanımlanması
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAsset> AccountAssets { get; set; }
        public DbSet<AccountFinance > AccountFinances { get; set; }
        public DbSet<AccountInformation> AccountInformations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsConfirmation> ProductsConfirmations { get; set; }
        public DbSet<CashConfirmation> CashConfirmations { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<SaleOrder> SaleOrders { get; set; }
        public DbSet<ShopHistory> ShopHistorys { get; set; }
    }
}
