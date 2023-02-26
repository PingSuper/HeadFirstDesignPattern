// See https://aka.ms/new-console-template for more information
using StrategyPattern;
using StrategyPattern.Algorithems;

Console.WriteLine("Hello, World!");

// Mallard Duck
Duck mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.Swim();
mallardDuck.PerformFly();
mallardDuck.PerformQuack();

// Rubber Duck
Duck rubberDuck = new RubberDuck();
rubberDuck.SetFlyBehavior(new FlyNoWay());
rubberDuck.SetQuackBehavior(new QuackSqueak());
rubberDuck.Display();
rubberDuck.Swim();
rubberDuck.PerformFly();
rubberDuck.PerformQuack();

// temp
Console.Read();