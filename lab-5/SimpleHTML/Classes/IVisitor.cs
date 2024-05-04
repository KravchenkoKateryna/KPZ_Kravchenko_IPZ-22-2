using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    public interface IVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode textNode);
    }
}
