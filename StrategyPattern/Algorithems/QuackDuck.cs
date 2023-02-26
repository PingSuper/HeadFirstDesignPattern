using System;
namespace StrategyPattern.Algorithems
{
	public class QuackDuck: IQuackBehavior
    {
        public QuackDuck()
        {
        }

        public void Quack()
        {
            Console.WriteLine("Quack Duck!");
        }
    }
}

