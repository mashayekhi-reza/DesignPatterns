namespace VisitorPattern.Example;

public class VacationVisitor : IEmployeeVisitor
{
	public void Visit(IEmployee employee)
	{
		if (employee is Engineer)
		{
			Console.WriteLine($"{employee.Name} has 20 vacation days.");
		}
		else if (employee is Manager)
		{
			Console.WriteLine($"{employee.Name} has 25 vacation days.");
		}
	}
}