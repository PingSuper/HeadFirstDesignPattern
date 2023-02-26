using System;
using StrategyPattern.Algorithems;

namespace StrategyPattern
{
	public class RubberDuck: Duck
	{
		public RubberDuck()
		{
		}

        public override void Display()
        {
            Console.WriteLine("This is Rubber Duck!");
        }

    }
}

