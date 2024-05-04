using SimpleHTML.Nodes;

namespace SimpleHTML.Classes
{
    internal class ChangeVisibilityCommand : ICommand
    {
        private LightElementNode _element;
        private string _displayType;

        public ChangeVisibilityCommand(LightElementNode element, string displayType)
        {
            _element = element;
            _displayType = displayType;
        }

        public void Execute()
        {
            _element.SetDisplayType(_displayType);
        }
    }
}
