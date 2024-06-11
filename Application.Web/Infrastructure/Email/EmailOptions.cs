namespace Application.Web.Infrastructure.Email;

public class EmailOptions
{
    public required string Host { get; set; }
    public required int Port { get; set; } = 587;
    public string Username { get; set; }
    public string Password { get; set; }

    public string FromAddress { get; set; }
    public string FromName { get; set; }

    public EmailOptions(string host, int port, string username, string password, string fromAddress, string fromName)
    {
        Host = host;
        Port = port;
        Username = username;
        Password = password;
        FromAddress = fromAddress;
        FromName = fromName;
    }
}
