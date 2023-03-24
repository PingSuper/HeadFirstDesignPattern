// See https://aka.ms/new-console-template for more information
using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Commands.CeilingFan;

Console.WriteLine("Hello, World!");

var remoteControl = new RemoteControl();

var light = new Light();
remoteControl.SetCommand(0,
    new LightOnCommand(light),
    new LightOffCommand(light));

var ceilingFan = new CeilingFan();
remoteControl.SetCommand(1,
    new CeilingFanOnCommand(ceilingFan),
    new CeilingFanOffCommand(ceilingFan));


remoteControl.OnButtonWasPressed(0);
remoteControl.OffButtonWasPressed(0);

remoteControl.OnButtonWasPressed(1);
remoteControl.OffButtonWasPressed(1);

Console.ReadKey();