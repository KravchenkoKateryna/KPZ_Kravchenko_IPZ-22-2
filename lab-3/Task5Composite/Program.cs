using Task5Composite.Nodes;

class Program
{
    static void Main()
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

        

    }
}