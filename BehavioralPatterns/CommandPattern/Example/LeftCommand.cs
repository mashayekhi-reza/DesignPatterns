namespace CommandPattern.Example;

public class LeftCommand : IRobotCommand
{
	private readonly Robot _robot;
	private readonly int _movement;

	public LeftCommand(Robot robot, int movement)
	{
		_robot = robot;
		_movement = movement;
	}

	public bool CanExecute()
	{
		return _robot.CanGoLeft(_movement);
	}

	public void Execute()
	{
		_robot.GoLeft(_movement);
	}

	public void Undo()
	{
		_robot.GoRight(_movement);
	}
}