// See https://aka.ms/new-console-template for more information


using StrategyPatternExample.BL.ConcreteStrategies;
using StrategyPatternExample.Models;

var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new ConcreteStrategyA());
context.DoSomeBusinessLogic();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new ConcreteStrategyB());
context.DoSomeBusinessLogic(); ;

