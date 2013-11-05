using System;
using System.Collections.Generic;
using System.Linq;
using Selflow.Engine.Abstraction;
using Selflow.Engine.Elements;

namespace Selflow.Engine.Entities
{
    public class WorkflowDefinition
    {
        public IList<IWorkflowElement> WorkflowElements { get; set; }

        public IEnumerable<StartElement> GetStartingElements()
        {
            return WorkflowElements.Where(element => element is StartElement).Cast<StartElement>();
        }

        public IEnumerable<IWorkflowElement> GetElementByIds(IList<string> toElements)
        {
            return WorkflowElements
                .Where(element => toElements.Any(s => s.Equals(element.ElementCode, StringComparison.CurrentCultureIgnoreCase)));
        }
    }
}