using Selflow.Engine.Elements;

namespace Selflow.Engine.Abstraction
{
    public interface IRuleEngine
    {
        bool CanExecuteElement(StartElement element);
    }
}