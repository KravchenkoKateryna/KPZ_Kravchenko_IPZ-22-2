using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    internal class InlineDisplayState : IDisplayState
    {
        public void ApplyStyle(LightElementNode element)
        {
            if (!element.Classes.Contains("inline"))
                element.Classes.Add("inline");

            if (element.Classes.Contains("block"))
                element.Classes.Remove("block");
        }
    }
}
