using System;
using System.Collections.Generic;
using System.Linq;

namespace Selflow.Engine.Exceptions
{
    [Serializable]
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(IList<string> elementNames)
            : base(string.Format("'{0}' element(s) not found.", elementNames.Aggregate((current, next) => current + "," + next)))
        {
        }
    }
}