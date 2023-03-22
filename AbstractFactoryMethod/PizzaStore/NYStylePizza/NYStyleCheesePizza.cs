using System;
using AbstractFactoryMethod.PizzaIngredientFactory;

namespace AbstractFactoryMethod.PizzaStore.NYStylePizza
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            name = "NY style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }

}

