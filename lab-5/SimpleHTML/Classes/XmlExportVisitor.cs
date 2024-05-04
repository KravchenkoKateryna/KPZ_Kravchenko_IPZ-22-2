using SimpleHTML.Nodes;
using System.Text;

namespace SimpleHTML.Classes
{
    public class XmlExportVisitor : IVisitor
    {
        private StringBuilder xmlOutput = new StringBuilder();
        private string _xmlEnd = string.Empty;

        public void ExportToXml(LightNode root)
        {
            xmlOutput.Clear();
            root.Accept(this);

            File.WriteAllText("output.xml", xmlOutput.ToString() + _xmlEnd);
        }

        public void Visit(LightElementNode element)
        {
            xmlOutput.Append($"<{element.TagName}");
            if (element.Classes.Count > 0)
                xmlOutput.Append($" class='{string.Join(" ", element.Classes)}'");

            xmlOutput.Append((element.IsSelfClosing ? "/>" : $">") + Environment.NewLine);

            _xmlEnd = element.IsSelfClosing ? string.Empty :  $"</{element.TagName}>" + Environment.NewLine + _xmlEnd;
        }

        public void Visit(LightTextNode textNode)
        {
            xmlOutput.Append(textNode.OuterHTML + Environment.NewLine);
        }
    }
}
