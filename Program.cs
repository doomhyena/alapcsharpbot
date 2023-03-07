using Discord;
using Discord.WebSocket;

public class Program
{
    private DiscordSocketClient _client;

    static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

    public async Task MainAsync()
    {
        _client = new DiscordSocketClient();

        _client.Log += Log;

        await _client.LoginAsync(TokenType.Bot, Config.Token);
        await _client.StartAsync();

        _client.MessageReceived += MessageReceived;

        await Task.Delay(-1);
    }

    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

    private async Task MessageReceived(SocketMessage message)
    {
        if (message.Content.StartsWith(Config.Prefix))
        {
            // Implement your command handling logic here
        }
    }
}
