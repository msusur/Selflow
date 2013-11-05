using System.Collections.Generic;
using Selflow.Engine.Abstraction;

namespace Selflow.Engine.Entities
{
    public class WorkflowContext
    {
        public WorkflowDefinition Definition { get; set; }

        public object Data { get; set; }

        public IEnumerable<IWorkflowElement> CurrentElements { get; set; }
    }
}