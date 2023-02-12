namespace MementoPattern.Example;

public class RobotMovementManager
{
	private readonly Stack<RobotMemento> _mementos;
	private RobotCommand _robotCommand;

	public RobotMovementManager()
	{
		_mementos = new Stack<RobotMemento>();
	}

	public void ExecuteCommand(RobotCommand robotCommand)
	{
		if (_robotCommand == null)
		{
			_robotCommand = robotCommand;
		}

		if (robotCommand.CanExecute())
		{
			robotCommand.Execute();
			_mementos.Push(robotCommand.CreateMemento());
		}
	}

	public void Undo()
	{
		if (_mementos.Any())
		{
			_robotCommand?.RestoreMemento(_mementos.Pop());
			_robotCommand?.Undo();
		}
	}
}