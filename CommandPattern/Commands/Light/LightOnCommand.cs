using System;
using CommandPattern.Commands;

namespace CommandPattern.Commands
{
	public class LightOnCommand : ICommand
	{
        private Light _light;

		public LightOnCommand(Light light)
		{
            _light = light;
		}

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}

