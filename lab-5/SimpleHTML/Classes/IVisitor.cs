using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    internal interface IVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode textNode);
    }
}
