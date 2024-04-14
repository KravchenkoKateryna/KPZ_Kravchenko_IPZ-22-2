using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    internal class DepthIterator : IIterator
    {
        private Stack<LightNode> _stack = new Stack<LightNode>();

        public DepthIterator(LightNode root)
        {
            _stack.Push(root);
        }

        public bool HasNext() => _stack.Count > 0;

        public LightNode Next()
        {
            var current = _stack.Pop();
            if (current.Children == null)
                return current;

            foreach (var child in current.Children)
                _stack.Push(child);
            
            return current;
        }
    }
}
