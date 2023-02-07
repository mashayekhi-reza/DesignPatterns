namespace FacadePattern.Example
{
	public class AccountStatusService : IAccountStatusService
	{
		public bool GetStatus(string accountNumber)
		{
			return accountNumber != "AccountA";
		}
	}
}
