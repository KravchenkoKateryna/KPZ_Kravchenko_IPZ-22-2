using SimpleHTML.Classes;

namespace SimpleHTML.Nodes
{
    public abstract class LightNode : LifecycleHooks
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public abstract void Accept(IVisitor visitor);
    }
}
