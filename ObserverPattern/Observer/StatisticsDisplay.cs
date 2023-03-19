using System;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
	public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private ISubject _subject;
        private WeatherDataArgs _weatherDataArgs;

        public StatisticsDisplay(ISubject subject)
		{
            _subject = subject;
            _subject.RegisterObserver(this);
            _weatherDataArgs = new WeatherDataArgs();
        }

        public void Display()
        {
            Console.WriteLine($"Statistics conditions: {_weatherDataArgs.Temperature} F degrees" +
                $"and  {_weatherDataArgs.Humidity}% humidity.");
        }

        public void Update(WeatherDataArgs weatherDataArgs)
        {
            _weatherDataArgs.Temperature = weatherDataArgs.Temperature;
            _weatherDataArgs.Humidity = weatherDataArgs.Humidity;
            _weatherDataArgs.Pressure = weatherDataArgs.Pressure;

            Display();
        }
    }
}

