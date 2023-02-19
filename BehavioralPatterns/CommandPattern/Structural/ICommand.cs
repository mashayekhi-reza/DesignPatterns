namespace CommandPattern.Structural;

public interface ICommand
{
	bool CanExecute();

	void Execute();

	void Undo();
}