namespace CommandPattern.Example;

public class Robot
{
	private int _location;

	public Robot()
	{
		_location = 0;

		Console.WriteLine($"Robot start location is: {_location}");
	}

	public bool CanGoLeft(int movement)
	{
		if (_location - movement < 0)
		{
			Console.WriteLine("It is an out of range left movement");
			return false;
		}
		return true;
	}

	public bool CanGoRight(int movement)
	{
		if (_location + movement > 100)
		{
			Console.WriteLine("It is an out of range right movement");
			return false;
		}
		return true;
	}

	public int GoLeft(int movement)
	{
		_location -= movement;
		Console.WriteLine($"Robot make {movement} unit move to left. The current location is: {_location}");
		return _location;
	}

	public int GoRight(int movement)
	{
		_location += movement;
		Console.WriteLine($"Robot make {movement} unit move to right. The current location is: {_location}");

		return _location;
	}
}