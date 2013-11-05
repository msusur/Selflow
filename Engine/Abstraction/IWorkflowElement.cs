using System.Collections.Generic;

namespace Selflow.Engine.Abstraction
{
    public interface IWorkflowElement
    {
        IList<string> ToElements { get; set; }
        
        string ElementCode { get; set; }
    }

    public interface IElementCondition
    {
    }
}