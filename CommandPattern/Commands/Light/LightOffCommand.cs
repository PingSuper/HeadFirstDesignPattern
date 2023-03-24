using System;
using CommandPattern.Commands;

namespace CommandPattern.Commands
{
	public class LightOffCommand : ICommand
	{
        private Light _light;

		public LightOffCommand(Light light)
		{
            _light = light;
		}

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}

