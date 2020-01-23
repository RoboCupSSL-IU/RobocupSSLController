using System;
using System.Linq;
using System.Net;
using System.Threading;
using RobocupSSLController.Gamepad;

namespace RobocupSSLController
{
    class Program
    {
        static void VisionReceive()
        {
            Console.WriteLine("Receiving vision packets");
            using VisionClient vc = new VisionClient.Builder().Build();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        static void RobotControl()
        {
            var team = RobocupTeam.Yellow;
            var robotId = 1;
            var robotCount = 8;
            
            using var output = (ICommandsOutput)new GrSimCommandsOutput(team, IPEndPoint.Parse("127.0.0.1:20011"));

            using var gamepad = EvDevDeviceInfo.EnumerateDevices()
                .Single(_ => _.DevicePath == "/dev/input/event25").OpenGamepad();
            
            var commands = Enumerable.Repeat(RobotCommand.Idle, robotCount).ToArray();

            var rnd = new Random();
            
            while (true)
            {
                Console.WriteLine("{0:#0.000} {1:#0.000} {2:#0.000} {3:#0.000}", gamepad.LeftX.Value, gamepad.LeftY.Value,
                    gamepad.RightX.Value, gamepad.RightY.Value);
                commands[robotId].VelocityTangent = gamepad.LeftY.Value;
                commands[robotId].VelocityNormal = gamepad.LeftX.Value;
                commands[robotId].AngularVelocity = gamepad.RightX.Value * 10;
                commands[robotId].EnableDribbler = true;
                output.PostCommands(commands.ToArray());
                Thread.Sleep(1000 / 60);
            }
        }
        
        static void Main(string[] args)
        {
            RobotControl();
        }
    }
}