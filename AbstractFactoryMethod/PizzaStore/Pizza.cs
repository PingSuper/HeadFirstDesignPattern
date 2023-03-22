using System;
using AbstractFactoryMethod.PizzaIngredientFactory;

namespace AbstractFactoryMethod.PizzaStore
{
    public abstract class Pizza
    {
        public Pizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        protected string name = "n/a";
        protected string dough = "n/a";
        protected string sauce = "n/a";
        protected List<string> toppings = new List<string>();
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            //Console.WriteLine("Tossing dough...");
            //Console.WriteLine("Adding sauce...");
            //Console.WriteLine("Adding toppings: ");
            //foreach (var topping in toppings)
            //{
            //    Console.WriteLine(" " + topping);
            //}

            pizzaIngredientFactory.CreateCheese();
            pizzaIngredientFactory.CreateDough();
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }
    }
}

