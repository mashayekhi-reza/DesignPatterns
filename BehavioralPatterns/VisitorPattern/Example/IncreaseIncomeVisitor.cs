namespace VisitorPattern.Example;

public class IncreaseIncomeVisitor : IEmployeeVisitor
{
	public void Visit(IEmployee employee)
	{
		if (employee is Engineer)
		{
			Console.WriteLine($"{employee.Name}'s income will be increased by 10%. Revised income is {employee.Income * 1.1}");
		}
		else if (employee is Manager)
		{
			Console.WriteLine($"{employee.Name}'s income will be increased by 15%. Revised income is {employee.Income * 1.15}");
		}
	}
}