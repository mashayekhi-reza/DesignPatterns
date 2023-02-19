namespace FlyweightPattern.Example;

public class DocumentFactory
{
	private readonly Dictionary<char, IDocumentItem> _characters = new();

	public IDocumentItem GetCharacter(char character)
	{
		if (!_characters.ContainsKey(character))
		{
			switch (character)
			{
				case 'a':
					_characters.Add(character, new CharacterA());
					break;
				case 'b':
					_characters.Add(character, new CharacterB());
					break;
				default:
					_characters.Add(character, new DefaultCharacter());
					break;
			}
		}
		return _characters[character];
	}

	public IDocumentItem GetParagraph(string text) => new Paragraph(text);
}