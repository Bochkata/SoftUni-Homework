

using System;

namespace T01Logger
{
    public class LayoutCreator
    {
        public ILayout CreateLayout(string type)
        {
            ILayout layout = null;
            if (type == nameof(SimpleLayout))
            {
                layout = new SimpleLayout();
            }
            else if (type == nameof(XmlLayout))
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new ArgumentException("Invalid type!");
            }

            return layout;
        }
    }
}
