using System;
using AbstractFactoryMethod.PizzaIngredient;

namespace AbstractFactoryMethod.PizzaIngredientFactory
{
	public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public ChicagoPizzaIngredientFactory()
		{
		}

        public Cheese CreateCheese()
        {
            Console.WriteLine("Create Parmesan Cheese...");
            return new ParmesanCheese();
        }

        public Dough CreateDough()
        {
            Console.WriteLine("Create Thick Crust Dough...");
            return new ThickCrustDough();
        }
    }
}

