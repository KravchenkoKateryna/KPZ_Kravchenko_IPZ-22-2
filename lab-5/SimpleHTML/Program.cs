using SimpleHTML.Classes;
using SimpleHTML.Nodes;

internal class Program
{
    private static void Main(string[] args)
    {
        var div = new LightElementNode("div", "block", false);
        div.Classes.Add("container");

        var p = new LightElementNode("p", "block", false);
        p.AddChild(new LightTextNode("Це текст у параграфі."));

        var img = new LightElementNode("img", "inline", true);
        img.Classes.Add("image-class");

        div.AddChild(p);
        div.AddChild(img);

        Console.WriteLine(div.OuterHTML);
        Console.WriteLine(div.InnerHTML);

        var element = new LightElementNode("div", "block", false);
        Console.WriteLine(element.OuterHTML);

        element.SetDisplayType("inline");

        Console.WriteLine(element.OuterHTML);


        // Example of using the XMLExportVisitor
        var rootElement = new LightElementNode("div", "block", false);
        rootElement.AddChild(new LightTextNode("Hello, world!"));
        rootElement.AddChild(new LightElementNode("p", "block", false));

        var xmlExporter = new XmlExportVisitor();
        xmlExporter.ExportToXml(rootElement);

        // Example of using the ChangeVisibilityCommand
        var elementToChange = new LightElementNode("div", "block", false);
        var changeVisibilityCommand = new ChangeVisibilityCommand(elementToChange, "inline");

        elementToChange.SetCommand(changeVisibilityCommand);

        elementToChange.ExecuteCommand();

        Console.WriteLine(elementToChange.OuterHTML);

        // Example of Iterator 
        var rootElementIter = new LightElementNode("html", "block", false);

        var head = new LightElementNode("head", "block", false);
        var body = new LightElementNode("body", "block", false);

        rootElementIter.AddChild(head);
        rootElementIter.AddChild(body);

        var title = new LightElementNode("title", "block", false);
        head.AddChild(title);

        var h1 = new LightElementNode("h1", "block", false);
        body.AddChild(h1);

        var h2 = new LightElementNode("h2", "block", false);
        body.AddChild(h2);

        var dfsIterator = new DepthIterator(rootElement);
        while (dfsIterator.HasNext())
        {
            var node = dfsIterator.Next();
            Console.WriteLine(node.OuterHTML);

        }

        var bfsIterator = new BreadthIterator(rootElement);
        while (bfsIterator.HasNext())
        {
            var node = bfsIterator.Next();
            Console.WriteLine(node.OuterHTML);
        }
    }
}