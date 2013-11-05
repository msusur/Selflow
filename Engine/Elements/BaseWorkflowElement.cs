using System.Collections.Generic;
using Selflow.Engine.Abstraction;

namespace Selflow.Engine.Elements
{
    public abstract class BaseWorkflowElement : IWorkflowElement
    {
        public IList<string> ToElements { get; set; }

        public string ElementCode { get; set; }
    }
}