namespace StatePattern.Example;

public class FullChargedState : IBatteryState
{
	public Robot Robot { get; set; }

	public FullChargedState(Robot robot)
	{
		Robot = robot;
	}

	public void UpdateBatteryState(ActionDifficultyLevel actionDifficultyLevel)
	{
		if (actionDifficultyLevel == ActionDifficultyLevel.Normal)
		{
			Robot.BatteryState = new SemiChargedState(Robot);
		}
		else if (actionDifficultyLevel == ActionDifficultyLevel.Difficult)
		{
			Robot.BatteryState = new LowChargedState(Robot);
		}

		Console.WriteLine($"The robot accomplished {actionDifficultyLevel} task and its battery state changed to {Robot.BatteryState.GetType().Name}");
	}
}