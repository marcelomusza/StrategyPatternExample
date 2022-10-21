namespace StrategyPatternExample.BL.ConcreteStrategies.Contracts
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
