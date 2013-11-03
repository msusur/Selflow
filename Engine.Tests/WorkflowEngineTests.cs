using Moq;
using Xunit;

namespace Selflow.Engine.Tests
{
    public class WorkflowEngineTests
    {
        [Fact]
        public void WorkflowEngineCanExecute()
        {
            var wfRepository = new Mock<IWorkflowRepository>();
            var sessionProvider = new Mock<ISessionProvider>();
            IWorkflowEngine engine = new WorkflowEngine(wfRepository.Object, sessionProvider.Object);


            var result = engine.StartNewInstance("TestFlow", new { id = 0, name = "test" });

            
        }
    }
}
