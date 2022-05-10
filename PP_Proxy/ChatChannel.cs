namespace PP_Proxy;

public class ChatChannel : IChannel
{
    private readonly string _userMail;
    private readonly TelegramConnection _telegramConnection;

    public ChatChannel(string userMail)
    {
        _userMail = userMail;
        _telegramConnection = new TelegramConnection();
    }

    public void Send(string message)
    {
        _telegramConnection.Open();
        _telegramConnection.SendMessage($"{_userMail}: {message}");
        _telegramConnection.Close();
    }
}