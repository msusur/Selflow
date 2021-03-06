﻿using Moq;
using Selflow.Engine.Abstraction;
using Selflow.Engine.Elements;
using Xunit;

namespace Selflow.Engine.Tests
{
    public class WorkflowEngineTests
    {

        /*      Tests needed to be codded
         *              - Workflow definition must contain at least one start element, so the workflow instance could start.
         *              - If Workflow definition cannot find a validated StartElement then it throws a CannotStartWorkflowInstanceException
         *              - If the start element inside the workflow definition doesn't have a valid condition it runs. First one gets the cake.
         *              - If workflow engine could find a start element it iterates over the next element. So a valid element must be found in the definition.
         *              - If an element points more than one elements, all the elements should be executed.
         *              - An element might point out one element. And that element might point out another element too. This may continue to infinity. 
         *              - Infinity loops must be eleminated during the recursive element execution process.
         *              - After the calculation of execution plan for current workflow definition, every path of elements must be executed asynchronously.
         */
        [Fact]
        public void WorkflowEngineCanExecute()
        {
            var wfRepository = new Mock<IWorkflowRepository>();
            var sessionProvider = new Mock<ISessionProvider>();
            var ruleEngine = new Mock<IRuleEngine>();
            var executionHelper = new SelflowExecutionHelper();
            IWorkflowEngine engine = new WorkflowEngine(wfRepository.Object, sessionProvider.Object, executionHelper, ruleEngine.Object);

            ruleEngine.Setup(engine1 => engine1.CanExecuteElement(It.IsAny<StartElement>())).Returns(true);

            var result = engine.StartNewInstance("TestFlow", new { id = 0, name = "test" });
        }
    }
}
