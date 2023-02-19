namespace FacadePattern.Example
{
	public class AccountFundService : IAccountFundService
	{
		private double _balance = 120;

		public void Deduct(double amount)
		{
			_balance -= amount;
		}

		public double GetBalance()
		{
			return _balance;
		}
	}
}
