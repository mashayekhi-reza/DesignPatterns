namespace MediatorPattern.Example;

public abstract class TeamMember
{
	public string Name { get; set; }

	protected IChatRoom? _chatRoom;

	public TeamMember(string name)
	{
		Name = name;
	}

	public void SetChatRoom(IChatRoom chatRoom)
	{
		_chatRoom = chatRoom;
	}

	public void Receive(string from, string message)
	{
		Console.WriteLine($"The message for {Name} is \"{message}\"");
	}

	public void Send(string message)
	{
		_chatRoom?.Send(Name, message);
	}

	public void SendToRole<T>(string message) where T : TeamMember
	{
		_chatRoom?.SendToRole<T>(Name, message);
	}
}