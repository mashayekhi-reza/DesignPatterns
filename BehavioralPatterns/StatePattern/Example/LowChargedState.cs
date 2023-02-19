namespace StatePattern.Example;

public class LowChargedState : IBatteryState
{
	public Robot Robot { get; set; }

	public LowChargedState(Robot robot)
	{
		Robot = robot;
	}

	public void UpdateBatteryState(ActionDifficultyLevel actionDifficultyLevel)
	{
		Console.WriteLine($"The robot is in {Robot.BatteryState.GetType().Name} and needs to be recharged to be able to accomplish {actionDifficultyLevel} tasks.");
	}
}