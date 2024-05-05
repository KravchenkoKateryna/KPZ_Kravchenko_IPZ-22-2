using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    internal class BreadthIterator : IIterator
    {
        private Queue<LightNode> _queue = new Queue<LightNode>();

        public BreadthIterator(LightNode root)
        {
            _queue.Enqueue(root);
        }

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            var current = _queue.Dequeue();
            foreach (var child in current.Children)
                _queue.Enqueue(child);
            return current;
        }
    }
}
