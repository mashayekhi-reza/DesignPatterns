namespace StatePattern.Example;

public class SemiChargedState : IBatteryState
{
	public Robot Robot { get; set; }

	public SemiChargedState(Robot robot)
	{
		Robot = robot;
	}

	public void UpdateBatteryState(ActionDifficultyLevel actionDifficultyLevel)
	{
		if (actionDifficultyLevel == ActionDifficultyLevel.Normal)
		{
			Robot.BatteryState = new LowChargedState(Robot);
			Console.WriteLine($"The robot accomplished {actionDifficultyLevel} task and its battery state changed to {Robot.BatteryState.GetType().Name}");
		}
		else if (actionDifficultyLevel == ActionDifficultyLevel.Difficult)
		{
			Console.WriteLine($"The robot is in {Robot.BatteryState.GetType().Name} and needs to be recharged to be able to accomplish {actionDifficultyLevel} tasks.");
		}
	}
}