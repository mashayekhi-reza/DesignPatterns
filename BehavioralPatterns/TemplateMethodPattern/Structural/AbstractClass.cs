namespace TemplateMethodPattern.Structural;

public abstract class AbstractClass
{
	public void TemplateMethod()
	{
		PrimitiveOperation1();
		PrimitiveOperation2();
	}

	public abstract void PrimitiveOperation1();
	public abstract void PrimitiveOperation2();
}