using SimpleHTML.Classes;

namespace SimpleHTML.Nodes
{
    public abstract class LightNode : LifecycleHooks
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public List<LightNode> Children { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}
