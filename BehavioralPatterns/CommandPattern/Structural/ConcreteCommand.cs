namespace CommandPattern.Structural;

public class ConcreteCommand : ICommand
{
	private readonly Receiver _receiver;

	public ConcreteCommand(Receiver receiver)
	{
		_receiver = receiver;
	}

	public bool CanExecute()
	{
		return true;
	}

	public void Execute()
	{
		_receiver.Action();
	}

	public void Undo()
	{
		_receiver.UndoAction();
	}
}