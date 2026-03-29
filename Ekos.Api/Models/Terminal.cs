namespace Ekos.Api.Models;

public class Terminal
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Ip { get; set; }
    public string Name { get; set; } = Environment.GetEnvironmentVariable("HOST_USER") ?? Environment.UserName;
    public string Domain { get; set; } = Environment.GetEnvironmentVariable("HOST_NAME") ?? Environment.MachineName;
    public string? UserAgent { get; set; }
}