using System;
using AbstractFactoryMethod.PizzaIngredientFactory;
using AbstractFactoryMethod.PizzaStore.ChicagoStylePizza;
using AbstractFactoryMethod.PizzaStore.NYStylePizza;

namespace AbstractFactoryMethod.PizzaStore
{
	public class ChicagoStylePizzaStore : PizzaStore
	{
		public ChicagoStylePizzaStore()
		{
		}

        public override Pizza CreatePizza(string type)
        {
            var pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza(pizzaIngredientFactory);
                
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

