using Database.Entities;
using Microsoft.EntityFrameworkCore;
using static Database.DbSettings;
#pragma warning disable CS8618

namespace Database;

public class BotDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
        optionsBuilder.EnableSensitiveDataLogging();
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<OrderLog> OrderLogs { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Deal> Deals { get; set; }
    
}