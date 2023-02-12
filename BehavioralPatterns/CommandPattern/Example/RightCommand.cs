namespace CommandPattern.Example;

public class RightCommand : IRobotCommand
{
	private readonly Robot _robot;
	private readonly int _movement;

	public RightCommand(Robot robot, int movement)
	{
		_robot = robot;
		_movement = movement;
	}

	public bool CanExecute()
	{
		return _robot.CanGoRight(_movement);
	}

	public void Execute()
	{
		_robot.GoRight(_movement);
	}

	public void Undo()
	{
		_robot.GoLeft(_movement);
	}
}