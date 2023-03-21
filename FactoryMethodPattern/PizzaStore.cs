using System;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern
{
	public class PizzaStore
	{
		private SimplePizzaFactory _factory;

		public PizzaStore(SimplePizzaFactory simplePizzaFactory)
		{
			_factory = simplePizzaFactory;
		}

		public Pizza OrderPizza(string type)
		{
			Pizza pizza;

			pizza = _factory.CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

			return pizza;
		}


	}
}

