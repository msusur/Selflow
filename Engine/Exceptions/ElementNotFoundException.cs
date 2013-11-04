using System;
using System.Collections.Generic;
using System.Linq;

namespace Selflow.Engine.Exceptions
{
    [Serializable]
    public class ElementNotFoundException : Exception
    {
        private readonly IList<string> _elementNames;

        public ElementNotFoundException(IList<string> elementNames)
            : base(string.Format("'{0}' element(s) not found.", elementNames.Aggregate((current, next) => current + "," + next)))
        {
            _elementNames = elementNames;
        }
    }
}