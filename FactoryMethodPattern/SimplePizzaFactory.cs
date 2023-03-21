using System;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern
{
	public class SimplePizzaFactory
	{
		public SimplePizzaFactory()
		{
		}

		public Pizza CreatePizza(string type) {
			switch (type)
			{
				case "Cheese":
					return new CheesePizza();
				case "Pepperoni":
					return new PepperoniPizza();
				default:
					throw new NotImplementedException();
			}
		}

	}
}

