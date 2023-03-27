// See https://aka.ms/new-console-template for more information
using TemplateMethodPattern;
using TemplateMethodPattern.ArraySortSample;

Console.WriteLine("Hello, World!");

// Tea
var tea = new Tea();
//tea.PrepareRecipe();

// Coffee
var coffee = new Coffee();
//coffee.PrepareRecipe();

// Array Sort
Duck[] ducks = new[] {
    new Duck("Daffy", 8),
    new Duck("Dewey", 2),
    new Duck("Howard", 7),
    new Duck("Louie", 2),
    new Duck("Donald", 10),
    new Duck("Huey", 2)
};

Console.WriteLine("Before sorting:");
Display(ducks);

// Template Method
Array.Sort<Duck>(ducks);

Console.WriteLine("After sorting:");
Display(ducks);

Console.ReadKey();

static void Display(Duck[] ducks)
{
    foreach (var duck in ducks)
    {
        Console.WriteLine(duck.ToString());
    }
}
