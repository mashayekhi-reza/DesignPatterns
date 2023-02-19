namespace StatePattern.Example;

public class Robot
{
	public IBatteryState BatteryState;

	public Robot()
	{
		BatteryState = new FullChargedState(this);
	}

	public void Act(ActionDifficultyLevel actionDifficultyLevel)
	{
		BatteryState.UpdateBatteryState(actionDifficultyLevel);
	}
}