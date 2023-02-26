using System;
using StrategyPattern.Algorithems;

namespace StrategyPattern
{
	public abstract class Duck
	{
		public Duck()
		{
			flyBehavior = new FlyWithWinds();
			quackBehavior = new QuackDuck();
		}

		public IFlyBehavior flyBehavior;
		public IQuackBehavior quackBehavior;

        // Methods
        public virtual void Swim() => Console.WriteLine("Duck Swimming!");

        public abstract void Display();

		public virtual void PerformQuack() => quackBehavior.Quack();

		public virtual void PerformFly() => flyBehavior.Fly();

		public virtual void SetFlyBehavior(IFlyBehavior flyBehavior)
			=> this.flyBehavior = flyBehavior;

		public virtual void SetQuackBehavior(IQuackBehavior quackBehavior)
			=> this.quackBehavior = quackBehavior;

	}


}

