namespace FacadePattern.Example
{
	public interface IAccountFundService
	{
		double GetBalance();
		void Deduct(double amount);
	}
}