namespace MementoPattern.Example;

public interface IRobotCommand
{
	bool CanExecute();

	void Execute();

	void Undo();
}