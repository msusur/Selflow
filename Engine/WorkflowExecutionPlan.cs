using System.Collections.Generic;

namespace Selflow.Engine
{
    internal class WorkflowExecutionPlan
    {
        private readonly IList<ElementExecutionTree> _elements = new List<ElementExecutionTree>();

        public void Add(ElementExecutionTree workflowElementsToExecute)
        {
            _elements.Add(workflowElementsToExecute);
        }

        public void ClearPlan()
        {
            _elements.Clear();
        }
    }
}