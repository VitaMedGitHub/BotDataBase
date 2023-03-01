namespace Database.Entities;

public class ClientLog
{
    public long Id { get; set; }
    public Client Client { get; set; } = null!;
    public DateTime Date { get; set; }
    public string ServiceName { get; set; } = null!;
}