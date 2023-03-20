using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
	public abstract class CondimentDecorator : Beverage
	{
		protected Beverage Beverage;

	}
}

