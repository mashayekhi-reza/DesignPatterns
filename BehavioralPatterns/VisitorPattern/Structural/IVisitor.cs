namespace VisitorPattern.Structural;

public interface IVisitor
{
	void VisitConcreteElementA(ConcreteElementA concreteElementA);
	void VisitConcreteElementB(ConcreteElementB concreteElementB);
}