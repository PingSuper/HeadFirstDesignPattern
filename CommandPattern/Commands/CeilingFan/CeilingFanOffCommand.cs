﻿using System;
namespace CommandPattern.Commands.CeilingFan
{
	public class CeilingFanOffCommand : ICommand
	{
        private readonly CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.Off();
        }

        public void Undo()
        {
            ceilingFan.On();
        }
    }
}

