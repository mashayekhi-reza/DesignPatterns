namespace IteratorPattern.Example;

public class Music
{
	public string Name { get; }
	public string Singer { get; }

	public Music(string name, string singer)
	{
		Name = name;
		Singer = singer;
	}
}