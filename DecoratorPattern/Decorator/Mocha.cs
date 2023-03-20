using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
	public class Mocha : CondimentDecorator
	{
		public Mocha(Beverage beverage)
		{
            this.Beverage = beverage;
            this.Description = this.Beverage.Description + ", Mocha"; 
		}

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.88m;
        }

    }
}

