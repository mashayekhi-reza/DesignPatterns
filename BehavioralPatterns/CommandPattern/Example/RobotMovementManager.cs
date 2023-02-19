namespace CommandPattern.Example;

public class RobotMovementManager
{
	private readonly Stack<IRobotCommand> _commands;

	public RobotMovementManager()
	{
		_commands = new Stack<IRobotCommand>();
	}

	public void ExecuteCommand(IRobotCommand robotCommand)
	{
		if (robotCommand.CanExecute())
		{
			robotCommand.Execute();
			_commands.Push(robotCommand);
		}
	}

	public void Undo()
	{
		if (_commands.Any())
		{
			_commands.Pop().Undo();
		}
	}
}