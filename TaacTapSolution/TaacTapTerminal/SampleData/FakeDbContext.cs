using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.SampleData
{


public class FakeDbContext : DbContext
{

    public DbSet<DbContextOrder> DbContextOrders { get; set; }
    public DbSet<DbContextItem> DbContextItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("FileName=TestOrder.db");
        var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "testOrderDB.db" };
        var connectionString = connectionStringBuilder.ToString();
        var connection = new SqliteConnection(connectionString);

        optionsBuilder.UseSqlite(connection);



    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<DbContextOrder>()
            .Property(b => b.DbContextOrderId)
            .IsRequired();


        modelBuilder.Entity<DbContextItem>()
            .Property(b => b.DbContextItemId)
            .IsRequired();
    }
}   
    }


public class DbContextOrder
{
    public int DbContextOrderId { get; set; }
    public string Location { get; set; }
    public List<DbContextItem> CurrentItemsOrdered { get; set; }
}

public class DbContextItem
{
    public int DbContextItemId { get; set; }
    public double price { get; set; }
    public string Description { get; set; }
}