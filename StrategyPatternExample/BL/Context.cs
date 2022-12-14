using StrategyPatternExample.BL.ConcreteStrategies.Contracts;

namespace StrategyPatternExample.Models
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {

        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy(not sure how it'll do it)");
            var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            var resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
