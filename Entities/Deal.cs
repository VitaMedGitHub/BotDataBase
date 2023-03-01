using System.ComponentModel.DataAnnotations;
using VitaMedBot.Data.Database;

namespace Database.Entities;

public class Deal
{
    [Key]
    public string Id { get; set; }
    public Client Client { get; set; }
    public DateTime CreationTime { get; set; }
}