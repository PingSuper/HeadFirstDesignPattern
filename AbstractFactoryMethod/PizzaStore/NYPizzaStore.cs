using System;
using AbstractFactoryMethod.PizzaIngredientFactory;
using AbstractFactoryMethod.PizzaStore.NYStylePizza;

namespace AbstractFactoryMethod.PizzaStore
{
	public class NYPizzaStore: PizzaStore
    {
		public NYPizzaStore()
		{
		}

        public override Pizza CreatePizza(string type)
        {
            var pizzaIngredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza(pizzaIngredientFactory);
                case "pepperoni":
                    return new NYStylePepperoniPizza(pizzaIngredientFactory);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

