namespace VisitorPattern.Example;

public interface IEmployeeVisitor
{
	void Visit(IEmployee employee);
}