namespace MementoPattern.Example;

public class RobotCommand : IRobotCommand
{
	protected Robot _robot;
	protected int _movement;

	public RobotCommand(Robot robot, int movement)
	{
		_robot = robot;
		_movement = movement;
	}

	public bool CanExecute()
	{
		return _robot.CanMove(_movement);
	}

	public void Execute()
	{
		_robot.Move(_movement);
	}

	public void Undo()
	{
		_robot.Return(_movement);
	}

	public void RestoreMemento(RobotMemento robotMemento)
	{
		_robot = robotMemento.Robot;
		_movement = robotMemento.Movement;
	}

	public RobotMemento CreateMemento()
	{
		return new RobotMemento(_robot, _movement);
	}
}