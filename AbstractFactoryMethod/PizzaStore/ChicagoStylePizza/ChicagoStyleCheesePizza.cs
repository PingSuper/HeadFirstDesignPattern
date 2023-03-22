using System;
using AbstractFactoryMethod.PizzaIngredientFactory;

namespace AbstractFactoryMethod.PizzaStore.ChicagoStylePizza
{
	public class ChicagoStyleCheesePizza : Pizza
	{
		public ChicagoStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            name = "Chicago style Deep and Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Bake()
        {
            Console.WriteLine("ChicagoStyle Cheese Pizza bake...");
        }

        public override void Box()
        {
            Console.WriteLine("ChicagoStyle Cheese Pizza box...");
        }

        public override void Cut()
        {
            Console.WriteLine("ChicagoStyle Cheese Pizza cut...");
        }

        
    }

}

