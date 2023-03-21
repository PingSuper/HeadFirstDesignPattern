// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;

Console.WriteLine("Hello, World!");

var pizzaStore = new PizzaStore(new SimplePizzaFactory());

var cheesePizza = pizzaStore.OrderPizza("Cheese");


Console.Read();

