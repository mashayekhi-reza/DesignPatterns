namespace VisitorPattern.Example;

public interface IEmployee
{
	string Name { get; }
	double Income { get; }

	void Accept(IEmployeeVisitor visitor);
}