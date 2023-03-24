using System;
namespace CommandPattern.Commands.CeilingFan
{
	public class CeilingFan
	{
		public CeilingFan()
		{
		}

        public void On()
        {
            Console.WriteLine("Ceiling Fan On!");
        }

        public void Off()
        {
            Console.WriteLine("Ceiling Fan Off!");
        }
    }
}

