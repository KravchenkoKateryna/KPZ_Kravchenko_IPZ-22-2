namespace Memento
{
    class Program
    {
        static void Main()
        {
            var editor = new TextEditor();

            editor.EditDocument("Hello, World!");

            // Зберігаємо стан
            var memento = editor.CreateMemento();

            // Відновлюємо стан
            editor.RestoreMemento(memento);

            // Перевіряємо, чи відновився текст
            Console.WriteLine("Restored Text: " + editor.GetDocumentText());
        }
    }
}