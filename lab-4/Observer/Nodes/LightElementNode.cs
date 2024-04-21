using System.Text;

namespace Observer
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; } // "block" або "inline"
        public bool IsSelfClosing { get; set; }
        public List<string> Classes { get; set; }
        public List<LightNode> Children { get; set; }


        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            Classes = new List<string>();
            Children = new List<LightNode>();
        }

        public override string OuterHTML
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append($"<{TagName}");
                if (Classes.Count > 0)
                {
                    sb.Append($" class='{string.Join(" ", Classes)}'");
                }
                sb.Append(IsSelfClosing ? "/>" : $">{InnerHTML}</{TagName}>");
                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }
    }
}
