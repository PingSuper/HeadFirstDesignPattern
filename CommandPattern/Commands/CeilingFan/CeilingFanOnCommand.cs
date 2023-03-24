using System;
namespace CommandPattern.Commands.CeilingFan
{
	public class CeilingFanOnCommand : ICommand
	{
        private readonly CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.On();
        }

        public void Undo()
        {
            ceilingFan.Off();
        }
    }
}

