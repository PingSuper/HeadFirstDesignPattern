// See https://aka.ms/new-console-template for more information
using ObserverPattern;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

Console.WriteLine("Hello, World!");

var weatherDataSubject = new WeatherDataSubject();

// Display 1
var currentConditionDisplay = new CurrentConditionDisplay(weatherDataSubject);

// Display 2
var statisticsDisplay = new StatisticsDisplay(weatherDataSubject);

weatherDataSubject.SetMeasurements(new WeatherDataArgs
{
    Temperature = 100,
    Humidity = 30,
    Pressure = 10
});


Console.Read();

