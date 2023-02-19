namespace StatePattern.Example;

public interface IBatteryState
{
	Robot Robot { get; set; }
	void UpdateBatteryState(ActionDifficultyLevel actionDifficultyLevel);
}