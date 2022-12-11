using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DomainModel.Models
{
    public class ResturantContext : DbContext
    {
        public ResturantContext() : base(@"Data Source=DESKTOP-6T91F6J\HEDIYEH;Initial Catalog=Resturant;User ID=sa;Password=123")
        {


        }
        public DbSet<DomainModel.Models.Cusstomer> Customers { get; set; }
        public DbSet<DomainModel.Models.Employee> Employees { get; set; }
        public DbSet<DomainModel.Models.Food> Foods { get; set; }
        public DbSet<DomainModel.Models.Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<DomainModel.Models.FoodCategory> FoodCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //haskey==prymary key
            modelBuilder.Entity<Cusstomer>().HasKey(x => x.CustomerID);
            modelBuilder.Entity<Cusstomer>().Property(x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Cusstomer>().Property(x => x.LastName).HasMaxLength(50);
            modelBuilder.Entity<Cusstomer>().Property(x => x.Mobile).HasMaxLength(20);
            //رابطه یک به n
            modelBuilder.Entity<Cusstomer>().HasMany(x => x.Orders).WithRequired(o => o.Customer).WillCascadeOnDelete();
            //modelBuilder.Entity<Order>().HasMany(x=>x.OrderDetails).WithRequired(x=>x.Orders).WillCascadeOnDelete();
            //باعث میشود تنظیمات دیفالت رو در نظر بگیرد 
            //وگرنه باید دستی خودمون ستینگ ست کنیم که بهتر است ست کنیم تا حافظه درگیر نشود 
            base.OnModelCreating(modelBuilder);
        }
    }
}
    





