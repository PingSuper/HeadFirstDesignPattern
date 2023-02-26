using System;
using StrategyPattern.Algorithems;

namespace StrategyPattern
{
	public class MallardDuck: Duck
	{
		public MallardDuck()
		{
		}

        public override void Display()
        {
            Console.WriteLine("This is MallardDuck!");
        }

    }
}

