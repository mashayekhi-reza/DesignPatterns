namespace IteratorPattern.Example;

public class MusicIterator : IMusicIterator
{
	private readonly MusicCollection _musicCollection;
	private int _index = 0;

	public MusicIterator(MusicCollection musicCollection)
	{
		_musicCollection = musicCollection;
	}

	public Music CurrentItem()
	{
		return _musicCollection[_index];
	}

	public Music First()
	{
		return _musicCollection[0];
	}

	public bool IsDone()
	{
		return _index >= _musicCollection.Count;
	}

	public Music? Next()
	{
		if (++_index < _musicCollection.Count)
		{
			return _musicCollection[_index];
		}
		return null;
	}
}