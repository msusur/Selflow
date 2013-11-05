using Selflow.Engine.Abstraction;
using Selflow.Engine.Entities;

namespace Selflow.Engine
{
    public class SelflowExecutionHelper :IWorkflowExecutionHelper
    {
        public WorkflowStatus ExecuteElement(WorkflowContext context)
        {
            var status = new WorkflowStatus
            {
                ExecutionPlan = new WorkflowExecutionPlan()
            };
            foreach (var workflowElement in context.CurrentElements)
            {
                ElementExecutionTree workflowElementsToExecute = CalculateExecutionPlan(workflowElement);
                status.ExecutionPlan.Add(workflowElementsToExecute);
            }
            return status;
        }

        private ElementExecutionTree CalculateExecutionPlan(IWorkflowElement workflowElement)
        {
            var tree = new ElementExecutionTree();

            foreach (var element in workflowElement.ToElements)
            {
                //plan inner element next elements
            }

            return tree;
        }
    }
}
