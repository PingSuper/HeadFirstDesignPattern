using System;
namespace DecoratorPattern.Component
{
	public abstract class Beverage
	{
		public Beverage()
		{
            Description = "Unknown Beverage";
		}

		public string Description;


        public abstract decimal Cost();

		

	}
}

