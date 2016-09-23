using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.Models.LocalData
{
  public   class LocalStorageDbContext :DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails{ get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RestaurantInfo> RestaurantInfo { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<User> Users { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=LocalStorage.db");
            //var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "testOrderDB.db" };
            //var connectionString = connectionStringBuilder.ToString();
            //var connection = new SqliteConnection(connectionString);

            //optionsBuilder.UseSqlite(connection);



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                              
                             .Property(b => b.BillId)
                             .IsRequired();

            modelBuilder.Entity<Menu>()
                            .Property(b => b.MenuId)
                            .IsRequired();

            modelBuilder.Entity<MenuItem>()
                         .Property(b => b.MenuItemId)
                         .IsRequired();

            modelBuilder.Entity<Order>()
                        .Property(b => b.OrderId)
                        .IsRequired();

            modelBuilder.Entity<OrderDetail>()
                         .Property(b => b.OrderId)
                         .IsRequired();

            modelBuilder.Entity<Payment>()
                        .Property(b => b.PaymentId)
                        .IsRequired();

            modelBuilder.Entity<Reservation>()
                       .Property(b => b.ReservationId)
                       .IsRequired();

            modelBuilder.Entity<RestaurantInfo>()
                       .Property(b => b.RestaurantInfoId)
                       .IsRequired();

            modelBuilder.Entity<RestaurantTable>()
                      .Property(b => b.RestaurantTableId)
                      .IsRequired();

            modelBuilder.Entity<User>()
                   .Property(b => b.UserId)
                   .IsRequired();
        }
    }
}
