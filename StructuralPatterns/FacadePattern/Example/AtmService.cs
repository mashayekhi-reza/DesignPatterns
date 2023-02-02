namespace FacadePattern.Example
{
	public class AtmService
	{
		private readonly IAccountStatusService _accountStatusService;
		private readonly IAccountFundService _accountFundService;

		public AtmService(IAccountStatusService accountStatusService,
			IAccountFundService accountFundService)
		{
			_accountStatusService = accountStatusService;
			_accountFundService = accountFundService;
		}

		public string Withdraw(string accountNumber, double amount)
		{
			if (!_accountStatusService.GetStatus(accountNumber))
			{
				return "Bank Account is not active!";
			}

			if(_accountFundService.GetBalance() < amount)
			{
				return "The balance is not sufficient!";
			}

			_accountFundService.Deduct(amount);

			return $"Withdraw completed and the remaining balance is {_accountFundService.GetBalance()}";
		}
	}
}
