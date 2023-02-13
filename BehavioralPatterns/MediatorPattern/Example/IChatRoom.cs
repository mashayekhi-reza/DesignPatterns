namespace MediatorPattern.Example;

public interface IChatRoom
{
	void Register(TeamMember teamMember);

	void Send(string from, string message);

	void SendToRole<T>(string from, string message) where T : TeamMember;
}