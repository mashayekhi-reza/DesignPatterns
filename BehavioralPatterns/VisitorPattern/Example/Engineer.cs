namespace VisitorPattern.Example;

public class Engineer : IEmployee
{
	public string Name { get; }

	public double Income { get; }

	public Engineer(string name, double income)
	{
		Name = name;
		Income = income;
	}

	public void Accept(IEmployeeVisitor visitor)
	{
		visitor.Visit(this);
	}
}