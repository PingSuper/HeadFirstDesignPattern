using System;
using AbstractFactoryMethod.PizzaIngredient;

namespace AbstractFactoryMethod.PizzaIngredientFactory
{
	public class NYPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public NYPizzaIngredientFactory()
		{
		}

        public Cheese CreateCheese()
        {
            Console.WriteLine("Create Mozzarella Cheese...");
            return new MozzarellaCheese();
        }

        public Dough CreateDough()
        {
            Console.WriteLine("Create Thin Crust Dough...");
            return new ThinCrustDough();
        }
    }
}

