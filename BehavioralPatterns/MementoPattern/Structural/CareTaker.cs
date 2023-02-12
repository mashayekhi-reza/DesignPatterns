namespace MementoPattern.Structural;

public class CareTaker
{
	private Memento memento;

    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}