using System;
namespace ObserverPattern.Observer
{
	public interface IObserver
	{
		void Update(WeatherDataArgs weatherDataArgs);
	}
}

