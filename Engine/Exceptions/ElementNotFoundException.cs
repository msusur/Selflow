using System;

namespace Selflow.Engine.Exceptions
{
    [Serializable]
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(string elementName)
            : base(string.Format("'{0}' element not found.", elementName))
        { }
    }
}