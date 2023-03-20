// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

Console.WriteLine("Hello, World!");

// HouseBlend Beverage
var houseBlend = new HouseBlend();

// HouseBlend, Milk
var milkHouseBlend = new Milk(houseBlend);

Console.WriteLine(milkHouseBlend.Description);
Console.WriteLine(milkHouseBlend.Cost());

// HouseBlend, Milk, Mocha
var mochaMilkHouseBlend = new Mocha(milkHouseBlend);
Console.WriteLine(mochaMilkHouseBlend.Description);
Console.WriteLine(mochaMilkHouseBlend.Cost());

Console.ReadKey();