namespace Memento
{
    class TextDocumentMemento
    {
        public string Text { get; }

        public TextDocumentMemento(string text)
        {
            Text = text;
        }
    }
}
