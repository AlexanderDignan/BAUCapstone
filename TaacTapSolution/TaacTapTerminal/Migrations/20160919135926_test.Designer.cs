using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TaacTapTerminal.SampleData;

namespace TaacTapTerminal.Migrations
{
    [DbContext(typeof(FakeDbContext))]
    [Migration("20160919135926_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("DbContextItem", b =>
                {
                    b.Property<int>("DbContextItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DbContextOrderDbContextOrderId");

                    b.Property<string>("Description");

                    b.Property<double>("price");

                    b.HasKey("DbContextItemId");
                });

            modelBuilder.Entity("DbContextOrder", b =>
                {
                    b.Property<int>("DbContextOrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.HasKey("DbContextOrderId");
                });

            modelBuilder.Entity("DbContextItem", b =>
                {
                    b.HasOne("DbContextOrder")
                        .WithMany()
                        .HasForeignKey("DbContextOrderDbContextOrderId");
                });
        }
    }
}
