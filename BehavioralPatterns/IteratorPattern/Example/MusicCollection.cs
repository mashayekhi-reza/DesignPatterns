namespace IteratorPattern.Example;

public class MusicCollection : List<Music>, IMusicCollection
{
	public IMusicIterator CreateIterator()
	{
		return new MusicIterator(this);
	}
}