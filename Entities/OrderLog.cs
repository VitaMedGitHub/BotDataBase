using System.ComponentModel.DataAnnotations;

namespace Database.Entities;

public class OrderLog
{
    [Key]
    public long Id { get; set; }
    public Client Client { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderName { get; set; }
}