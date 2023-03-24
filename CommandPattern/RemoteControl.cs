using System;
using CommandPattern.Commands;

namespace CommandPattern
{
	public class RemoteControl
	{
		private ICommand[] _onCommands;
		private ICommand[] _offCommands;
		private ICommand _undoCommand;

		public RemoteControl()
		{
			_onCommands = new ICommand[7];
			_offCommands = new ICommand[7];

			var noCommand = new NoCommand();

			for (int i = 0; i < 7; i++)
			{
				_onCommands[i] = noCommand;
				_offCommands[i] = noCommand;
			}
			_undoCommand = noCommand;
		}

		public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
		{
			_onCommands[slot] = onCommand;
			_offCommands[slot] = offCommand;
		}

		public void OnButtonWasPressed(int slot) {
			_onCommands[slot].Execute();
			_undoCommand = _onCommands[slot];
		}

        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Execute();
			_undoCommand = _offCommands[slot];
        }

		public void UndoButtonWasPressed() {
			_undoCommand.Undo();
		}

    }
}

