namespace CommandPattern.Example;

public interface IRobotCommand
{
	bool CanExecute();

	void Execute();

	void Undo();
}