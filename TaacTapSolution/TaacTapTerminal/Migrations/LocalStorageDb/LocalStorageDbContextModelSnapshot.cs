using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TaacTapTerminal.Models.LocalData;

namespace TaacTapTerminal.Migrations.LocalStorageDb
{
    [DbContext(typeof(LocalStorageDbContext))]
    partial class LocalStorageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("TaacTapTerminal.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<double>("SubTotal");

                    b.Property<double>("TaxRate");

                    b.Property<double>("TipP");

                    b.HasKey("BillId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MenuName")
                        .IsRequired();

                    b.Property<string>("RestaurantInfo")
                        .IsRequired();

                    b.HasKey("MenuId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("MenuId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrderOrderId");

                    b.Property<double>("Price");

                    b.HasKey("MenuItemId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<int?>("RestaurantTableRestaurantTableId");

                    b.Property<int>("TableId");

                    b.Property<double>("TotalPrice");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MenuItemId");

                    b.HasKey("OrderId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<int>("BillId");

                    b.Property<int>("BillOrderId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("PaymentId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("RestaurantTableId");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("ReservationId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.RestaurantInfo", b =>
                {
                    b.Property<int>("RestaurantInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumberOfTables");

                    b.Property<string>("phone")
                        .IsRequired();

                    b.HasKey("RestaurantInfoId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.RestaurantTable", b =>
                {
                    b.Property<int>("RestaurantTableId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("RestaurantTableId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountType")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("UserId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.MenuItem", b =>
                {
                    b.HasOne("TaacTapTerminal.Models.Order")
                        .WithMany()
                        .HasForeignKey("OrderOrderId");
                });

            modelBuilder.Entity("TaacTapTerminal.Models.Order", b =>
                {
                    b.HasOne("TaacTapTerminal.Models.RestaurantTable")
                        .WithMany()
                        .HasForeignKey("RestaurantTableRestaurantTableId");
                });
        }
    }
}
