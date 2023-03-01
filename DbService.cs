using Database.Entities;
using Microsoft.EntityFrameworkCore;


namespace Database;

public static class DbService
{
    public static readonly BotDbContext Context = new();
    public static DbSet<Client> Clients => Context.Clients;
    public static DbSet<Branch> Branches => Context.Branches;
    public static DbSet<Service> Services => Context.Services;
    public static DbSet<OrderLog> OrderLogs => Context.OrderLogs;
    public static DbSet<User> Users => Context.Users;

    public static async Task<Client> GetOrCreateClient(long userId)
    {
        return await Context.Clients.FindAsync(userId) ?? new Client(userId);
    }

    public static bool Register()
    {
        try
        {
            Context.Database.EnsureCreated();
            Context.Clients.Load();
            Context.OrderLogs.Load();
            Context.Branches.Load();
            Context.Services.Load();
            Context.Users.Load();
            Context.Deals.Load();
            //DataGen.GenerateData();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public delegate Task TaskAction(BotDbContext db);

    public static async void GetContext(TaskAction task)
    {
        await using BotDbContext db = new();
        await task(db);
    }

    public static async Task AddOrUpdateAsync<T>(this DbSet<T> dbSet, T entity) where T: class
    {
        await Task.Factory.StartNew(() =>
        {
            if (dbSet.Contains(entity))
            {
                dbSet.Update(entity);
            }
            else
            {
                dbSet.AddAsync(entity);
            }
        });
    }
}