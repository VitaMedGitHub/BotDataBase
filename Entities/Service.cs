using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618

namespace Database.Entities;

public class Service
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Price { get; set; }
    public string? About { get; set; }
    public List<Branch>? Branches { get; set; }
}