using System.ComponentModel.DataAnnotations;

namespace Database.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
}