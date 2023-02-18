namespace VisitorPattern.Example;

public class Employees
{
	private readonly List<IEmployee> _employees;

	public Employees()
	{
		_employees = new();
	}

	public void Attach(IEmployee employee)
	{
		_employees.Add(employee);
	}

	public void Accept(IEmployeeVisitor visitor)
	{
		foreach(var employee in _employees)
		{
			visitor.Visit(employee);
		}
	}
}