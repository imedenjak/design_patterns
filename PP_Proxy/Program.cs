
using PP_Proxy;

string userMail = "troll@example.com";

IChannel channel = new BlacklistedChannel(userMail);

BlacklistedChannel.BlacklistedUsers.Add(userMail);

channel.Send("You are stupid");

Console.ReadLine();