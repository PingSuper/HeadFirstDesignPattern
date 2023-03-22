using System;
using AbstractFactoryMethod.PizzaIngredientFactory;

namespace AbstractFactoryMethod.PizzaStore.NYStylePizza
{
	public class NYStylePepperoniPizza : Pizza
    {
		public NYStylePepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            name = "NY style Sauce and Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }

        
    }
}

