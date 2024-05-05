using SimpleHTML.Classes;
using System.Text;

namespace SimpleHTML.Nodes
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; } // "block" або "inline"
        public bool IsSelfClosing { get; set; }
        public List<string> Classes { get; set; }

        private IDisplayState _displayState;
        private ICommand _command;

        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
            Classes = new List<string>();
            Children = new List<LightNode>();
            _displayState = displayType == "block" ? new BlockDisplayState() : new InlineDisplayState();
            OnCreated();
        }

        public void SetDisplayType(string displayType)
        {
            _displayState = displayType == "block" ? new BlockDisplayState() : new InlineDisplayState();
            OnDisplayTypeChanged();
        }
        
        public override string OuterHTML
        {
            get
            {
                _displayState.ApplyStyle(this);
                var sb = new StringBuilder();
                sb.Append($"<{TagName}");
                if (Classes.Count > 0)
                    sb.Append($" class='{string.Join(" ", Classes)}'");

                sb.Append(IsSelfClosing ? "/>" : $">{InnerHTML}</{TagName}>");

                return sb.ToString();
            }
        }

        public override void OnCreated()
        {
            Console.WriteLine($"Element {TagName} created.");
        }

        public override void OnDisplayTypeChanged()
        {
            Console.WriteLine($"Element {TagName} display type changed.");
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                    sb.Append(child.OuterHTML);

                return sb.ToString();
            }
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in Children)
                child.Accept(visitor);
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
