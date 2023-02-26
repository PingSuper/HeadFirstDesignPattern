using System;
namespace StrategyPattern.Algorithems
{
	public class QuackSqueak: IQuackBehavior
    {
		public QuackSqueak() 
		{
		}

        public void Quack()
        {
            Console.WriteLine("Quack Squeak - Rubber duck!");
        }
    }
}

