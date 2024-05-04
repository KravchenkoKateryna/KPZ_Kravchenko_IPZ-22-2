using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    internal class BlockDisplayState : IDisplayState
    {
        public void ApplyStyle(LightElementNode element)
        {
            if (!element.Classes.Contains("block"))
                element.Classes.Add("block");

            if (element.Classes.Contains("inline"))
                element.Classes.Remove("inline");
        }
    }
}
