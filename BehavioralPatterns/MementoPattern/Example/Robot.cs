namespace MementoPattern.Example;

public class Robot
{
	private int _location;

	public Robot()
	{
		_location = 0;

		Console.WriteLine($"Robot start location is: {_location}");
	}

	public bool CanMove(int movement)
	{
		if (movement > 100)
		{
			Console.WriteLine("It is an out of range movement");
			return false;
		}
		return true;
	}

	public int Move(int movement)
	{
		_location += movement;
		Console.WriteLine($"Robot make {movement} unit move. The current location is: {_location}");
		return _location;
	}

	public int Return(int movement)
	{
		_location -= movement;
		Console.WriteLine($"Robot make {movement} unit return. The current location is: {_location}");

		return _location;
	}
}