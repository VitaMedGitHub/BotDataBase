using System.ComponentModel.DataAnnotations;

namespace Database.Entities;

public class Branch
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ReplyText { get; set; }
    public string? ButtonMap { get; set; }
    public Branch? Parent { get; set; }
    public List<Branch>? Children { get; set; }
    public Service? Service { get; set; }
}