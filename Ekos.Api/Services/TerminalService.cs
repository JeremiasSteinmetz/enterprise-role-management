using Ekos.Api.Models;

namespace Ekos.Api.Services;

public class TerminalService
{
    public Terminal GetTerminalInfo(string? userAgent, string? remoteIp)
    {
        return new Terminal
        {
            Ip = remoteIp ?? "127.0.0.1",
            UserAgent = userAgent ?? "N/A",
            Name = Environment.GetEnvironmentVariable("HOST_USER") ?? Environment.UserName,
            Domain = Environment.GetEnvironmentVariable("HOST_NAME") ?? Environment.MachineName
        };
    }
}