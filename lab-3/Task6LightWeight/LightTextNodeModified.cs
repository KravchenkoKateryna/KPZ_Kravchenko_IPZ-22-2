namespace Task6LightWeight
{
    internal class LightTextNodeModified : LightNodeModified
    {
        private string _text;

        public LightTextNodeModified(string text)
        {
            _text = text;
        }

        public override string OuterHTML => _text;
    }
}
