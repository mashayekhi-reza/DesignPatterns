﻿namespace VisitorPattern.Structural;

public class ConcreteElementB : IElement
{
	public void Accept(IVisitor visitor)
	{
		visitor.VisitConcreteElementB(this);
	}
}