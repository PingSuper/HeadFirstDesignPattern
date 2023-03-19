using System;
namespace ObserverPattern
{
	public class WeatherDataArgs
	{
		public WeatherDataArgs()
		{
		}

		public float Temperature { get; set; }
		public float Humidity { get; set; }
		public float Pressure { get; set; }


    }
}

