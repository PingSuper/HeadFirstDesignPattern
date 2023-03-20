using System;
namespace DecoratorPattern.Component
{
	public class HouseBlend : Beverage
	{
		public HouseBlend()
		{
            Description = "House Blend Coffee";
		}

        public override decimal Cost()
        {
            return 1.99m;
        }
    }
}

