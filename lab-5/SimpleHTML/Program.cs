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
    }
}