using UserDefinedCompoundOperators;

var channel = new Channel();
channel++;

Console.WriteLine($"Subscribers: {channel.Subscribers}, Members: {channel.Members}");
