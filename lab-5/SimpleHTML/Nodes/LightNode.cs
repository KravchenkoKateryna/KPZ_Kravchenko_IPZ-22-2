using SimpleHTML.Classes;

namespace SimpleHTML.Nodes
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public abstract void Accept(IVisitor visitor);
    }
}
