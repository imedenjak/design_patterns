namespace PP_Proxy;

/// <summary>
///  Proxy class
/// </summary>
public class BlacklistedChannel : IChannel
{
    public static readonly List<string> BlacklistedUsers = new();
    private readonly string _userMail;
    private readonly ChatChannel _realChannel;

    public BlacklistedChannel(string userMail)
    {
        _realChannel = new ChatChannel(userMail);  // Could be lazy instantiated within Send
        _userMail = userMail;
    }
    
    public void Send(string message)
    {
        if (!BlacklistedUsers.Contains(_userMail))
        {
            _realChannel.Send(message);
        }
    }
}