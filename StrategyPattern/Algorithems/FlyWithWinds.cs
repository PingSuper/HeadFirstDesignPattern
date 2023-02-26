using System;
namespace StrategyPattern.Algorithems
{
	public class FlyWithWinds : IFlyBehavior
    {
		public FlyWithWinds()
		{
		}

        public void Fly()
        {
            Console.WriteLine("Fly with Winds!");
        }
    }
}

