using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
	public class Milk : CondimentDecorator
    {
		public Milk(Beverage beverage)
		{
            this.Beverage = beverage;
            this.Description = Beverage.Description + ", Milk";
		}

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.99m;
        }

        
    }
}

