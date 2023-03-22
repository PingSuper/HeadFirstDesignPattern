// See https://aka.ms/new-console-template for more information
using AbstractFactoryMethod.PizzaStore;

Console.WriteLine("Hello, World!");

//
var nyStylePizzaStore = new NYPizzaStore();

var nyStyleCheesePizze = nyStylePizzaStore.OrderPizza("cheese");

Console.WriteLine("Ethan ordered a " + nyStyleCheesePizze.GetName());

Console.WriteLine("-----------------");
//
var chicagoStylePizzaStore = new ChicagoStylePizzaStore();

var chicagoStylePizza = chicagoStylePizzaStore.OrderPizza("cheese");

Console.WriteLine("Joel ordered a " + chicagoStylePizza.GetName());


Console.Read();

