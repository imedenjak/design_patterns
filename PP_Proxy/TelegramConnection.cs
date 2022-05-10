using System.Threading.Channels;

namespace PP_Proxy;

internal class TelegramConnection
{
    public void Open()
    {
        Console.WriteLine("- connect to Telegram");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"- send message: {message}");
    }

    public void Close()
    {
        Console.WriteLine("- close connection to Telegram");
    }
}