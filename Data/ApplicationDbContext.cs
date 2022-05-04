using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public string DbPath { get; }
    public ApplicationDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "TestApplication.db");
    }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

    public DbSet<Customer> Customers {get; set;}

    
}