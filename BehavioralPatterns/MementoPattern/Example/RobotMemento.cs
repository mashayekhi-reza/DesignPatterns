namespace MementoPattern.Example;

public class RobotMemento
{
	public int Movement { get; private set; }
	public Robot Robot { get; private set; }

	public RobotMemento(Robot robot, int movement)
	{
		Robot = robot;
		Movement = movement;
	}
}