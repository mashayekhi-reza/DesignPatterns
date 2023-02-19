namespace CommandPattern.Structural;

public class Invoker
{
	private ICommand? _command;

	public void SetCommand(ICommand command) => _command = command;

	public void ExecuteCommand()
	{
		if (_command.CanExecute())
		{
			_command.Execute();
		}
	}

	public void UndoCommand()
	{
		_command.Undo();
	}
}