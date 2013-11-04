using System;
using System.Collections.Generic;
using System.Linq;
using Selflow.Engine.Abstraction;
using Selflow.Engine.Elements;

namespace Selflow.Engine
{
    public class WorkflowDefinition
    {
        public IList<IWorkflowElement> WorkflowElements { get; set; }

        public IEnumerable<StartElement> GetStartingElements()
        {
            return WorkflowElements.Where(element => element is StartElement).Cast<StartElement>();
        }

        public IWorkflowElement GetElementById(string toElement)
        {
            return
                WorkflowElements.FirstOrDefault(
                    element => element.ElementCode.Equals(toElement, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}