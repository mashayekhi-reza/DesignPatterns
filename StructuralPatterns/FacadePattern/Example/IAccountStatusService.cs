namespace FacadePattern.Example
{
	public interface IAccountStatusService
	{
		bool GetStatus(string accountNumber);
	}
}