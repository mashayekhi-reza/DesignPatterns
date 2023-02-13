namespace MediatorPattern.Example;

public class ChatRoom : IChatRoom
{
	private readonly List<TeamMember> _teamMembers;

	public ChatRoom()
	{
		_teamMembers = new();
	}

	public void Register(TeamMember teamMember)
	{
		teamMember.SetChatRoom(this);
		if (!_teamMembers.Contains(teamMember))
		{
			_teamMembers.Add(teamMember);
		}
	}

	public void Send(string from, string message)
	{
		foreach(var member in _teamMembers.Where(m => m.Name != from))
		{
			member.Receive(from, message);
		}
	}

	public void SendToRole<T>(string from, string message) where T : TeamMember
	{
		foreach (var member in _teamMembers.OfType<T>().Where(m => m.Name != from))
		{
			member.Receive(from, message);
		}
	}
}