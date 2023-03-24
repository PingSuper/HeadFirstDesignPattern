using System;
namespace CommandPattern.Commands
{
	public class NoCommand: ICommand
	{
		public NoCommand()
		{
		}

        public void Execute()
        {
            Console.WriteLine("No command...");
        }
    }
}

