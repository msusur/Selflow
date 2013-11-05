using System.Collections.Generic;
using Selflow.Engine.Abstraction;

namespace Selflow.Engine
{
    internal class ElementExecutionTree
    {
        public IList<ElementExecutionNode> NodeList { get; set; }
    }

    internal class ElementExecutionNode
    {
        public IWorkflowElement WorkflowElement { get; set; }
        public ElementExecutionNode ChildNode { get; set; }
    }
}