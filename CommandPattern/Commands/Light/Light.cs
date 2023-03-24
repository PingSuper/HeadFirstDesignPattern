using System;
namespace CommandPattern.Commands
{
	public class Light
	{
		public Light()
		{
		}

		public void On()
		{
			Console.WriteLine("Light On!");
		}

		public void Off()
		{
            Console.WriteLine("Light Off!");
        }
	}
}

