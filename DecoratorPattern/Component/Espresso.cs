using System;
namespace DecoratorPattern.Component
{
	public class Espresso : Beverage
	{
		public Espresso()
		{
            this.Description = "Espresso";
		}

        public override decimal Cost()
        {
            return 0.99m;
        }
    }
}

