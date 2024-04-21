namespace Memento
{
    class TextEditor
    {
        private TextDocument _document;

        public TextEditor()
        {
            _document = new TextDocument();
        }

        public void EditDocument(string newText)
        {
            _document.Text = newText;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(_document.Text);
        }

        public void RestoreMemento(TextDocumentMemento memento)
        {
            _document.Text = memento.Text;
        }

        public string GetDocumentText()
        {
            return _document.Text;
        }
    }
}
