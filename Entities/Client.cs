#nullable enable
using System.ComponentModel.DataAnnotations;
using VitaMedBot.Data.Database;

namespace Database.Entities;

public class Client
{
    [Key]
    public long Id { get; set; }
    public string? Phone { get; set; }     
    public string? Name { get; set; }
    public bool PrivacyAccept { get; set; }
    public Input InputMode { get; set; } = 0;
    public string? SelectedService { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public List<OrderLog> OrderLogs { get; set; } = new List<OrderLog>();
    public List<Deal> Deals { get; set; } = new List<Deal>();
    public double? Longitude { get; set; }
    public double? Latitude { get; set; }

    public Client(){}
    
    public Client(long id)
    {
        Id = id;
    }

    public void Reset()
    {
        Name = null;
        Phone = null;
        PrivacyAccept = false; 
    }
    
    public static async Task<bool> HasContact(long userId)
    {
        var user = await DbService.Context.Clients.FindAsync(userId);
        return user != null && user.Name != null && user.Phone != null;
    } 
}