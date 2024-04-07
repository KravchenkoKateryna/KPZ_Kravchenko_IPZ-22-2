namespace Task6LightWeight
{
    internal class LightElementNodeModified : LightNodeModified
    {
        private static Dictionary<string, LightElementNodeModified> _flyweight = new Dictionary<string, LightElementNodeModified>();
        public string TagName { get; private set; }
        public List<LightNodeModified> Children { get; private set; }

        public static LightElementNodeModified GetFlyweight(string tagName)
        {
            if (!_flyweight.ContainsKey(tagName))
            {
                _flyweight[tagName] = new LightElementNodeModified(tagName);
            }
            return _flyweight[tagName];
        }
        public LightElementNodeModified(string tagName)
        {
            TagName = tagName;
            Children = new List<LightNodeModified>();
        }
        public void AddChild(LightNodeModified child)
        {
            Children.Add(child);
        }
        public override string OuterHTML
        {
            get
            {
                var childrenHTML = Children.Select(child => child.OuterHTML).Aggregate((a, b) => a + b);
                return $"<{TagName}>{childrenHTML}</{TagName}>";
            }
        }

    }
}
