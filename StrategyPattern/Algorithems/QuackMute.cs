using System;
namespace StrategyPattern.Algorithems
{
	public class QuackMute: IQuackBehavior
    {
		public QuackMute()
		{
		}

        public void Quack()
        {
            Console.WriteLine("Quack Mute - can't quack!");
        }
    }
}

