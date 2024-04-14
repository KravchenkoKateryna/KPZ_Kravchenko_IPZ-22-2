using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    public interface IIterator
    {
        bool HasNext();
        LightNode Next();
    }
}
