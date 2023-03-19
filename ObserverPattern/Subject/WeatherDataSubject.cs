using System;
using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
	public class WeatherDataSubject: ISubject
	{
        private List<IObserver> _observers;
        private WeatherDataArgs _weatherDataArgs;
        
		public WeatherDataSubject()
		{
            _observers = new List<IObserver>();
            _weatherDataArgs = new WeatherDataArgs();
		}

        public void NotifyObservers()
        {
            if (!_observers.Any()) {
                return;
            }

            foreach (var observer in _observers)
            {
                observer.Update(_weatherDataArgs);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(WeatherDataArgs weatherDataArgs)
        {
            _weatherDataArgs.Temperature = weatherDataArgs.Temperature;
            _weatherDataArgs.Humidity = weatherDataArgs.Humidity;
            _weatherDataArgs.Pressure = weatherDataArgs.Pressure;

            MeasurementsChanged();
        }

    }
}

