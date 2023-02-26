using System;
namespace StrategyPattern.Algorithems
{
	public class FlyNoWay : IFlyBehavior
    {
		public FlyNoWay()
		{
		}

        public void Fly()
        {
            Console.WriteLine("Fly no Way!");
        }
    }
}

