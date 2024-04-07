using Task5Composite.Nodes;
using Task6LightWeight;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] bookLines = File.ReadAllLines("pg1513.txt");
        bool oldMethod = false;

        if (oldMethod)
        {
            var root = new LightElementNode("div", "block", false);
            for (int i = 0; i < bookLines.Length; i++)
            {
                string line = bookLines[i];
                LightElementNode elementNode;
                if (i == 0)
                {
                    elementNode = new LightElementNode("h1", "inline", false);
                }
                else if (line.Length < 20)
                {
                    elementNode = new LightElementNode("h2", "inline", false);
                }
                else if (line.StartsWith(" "))
                {
                    elementNode = new LightElementNode("blockquote", "block", false);
                }
                else
                {
                    elementNode = new LightElementNode("p", "block", false);
                }
                elementNode.AddChild(new LightTextNode(line));
                root.AddChild(elementNode);
            }
            //Console.WriteLine(root.OuterHTML);
        }
        else
        {
            var root = new LightElementNodeModified("div");
            for (int i = 0; i < bookLines.Length; i++)
            {
                string line = bookLines[i];
                LightElementNodeModified elementNode;
                if (i == 0)
                {
                    elementNode = LightElementNodeModified.GetFlyweight("h1");
                }
                else if (line.Length < 20)
                {
                    elementNode = LightElementNodeModified.GetFlyweight("h2");
                }
                else if (line.StartsWith(" "))
                {
                    elementNode = LightElementNodeModified.GetFlyweight("blockquote");
                }
                else
                {
                    elementNode = LightElementNodeModified.GetFlyweight("p");
                }

                elementNode.AddChild(new LightTextNodeModified(line));
                root.AddChild(elementNode);
            }
            //Console.WriteLine(root.OuterHTML);
            // Використання пам'яті: 1155712 байтів
        }


        // Показуємо використання пам'яті
        long memoryUsed = GC.GetTotalMemory(true);
        Console.WriteLine($"Використання пам'яті: {memoryUsed} байтів"); //  Memory usage for old method: 2173936 bytes
    }
}