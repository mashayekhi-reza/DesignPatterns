namespace VisitorPattern.Example;

public class Manager : IEmployee
{
	public string Name { get; }

	public double Income { get; }

	public Manager(string name, double income)
	{
		Name = name;
		Income = income;
	}

	public void Accept(IEmployeeVisitor visitor)
	{
		visitor.Visit(this);
	}
}