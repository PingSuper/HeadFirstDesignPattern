using System;
using AbstractFactoryMethod.PizzaIngredient;

namespace AbstractFactoryMethod.PizzaIngredientFactory
{
	public interface IPizzaIngredientFactory
	{
		public Dough CreateDough();
		public Cheese CreateCheese();

	}
}

