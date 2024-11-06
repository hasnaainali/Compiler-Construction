using System;
using System.Collections.Generic;

namespace CarCommandSimulator
{
    class Program
    {
        static readonly List<string> validCommands = new List<string> { "Start", "Stop", "Accelerate", "Brake", "Right" };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ziyad's Car Command Simulator!");
            Console.WriteLine("Enter a sequence of commands separated by spaces (Available commands: Start, Stop, Accelerate, Brake, Right):");

            string input = Console.ReadLine();
            string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string command in commands)
            {
                ExecuteCommand(command);
            }

            Console.WriteLine("All commands processed. End of simulation.");
        }

        static void ExecuteCommand(string command)
        {
            if (validCommands.Contains(command))
            {
                switch (command)
                {
                    case "Start":
                        Console.WriteLine("Car is starting...");
                        break;
                    case "Stop":
                        Console.WriteLine("Car is stopping...");
                        break;
                    case "Accelerate":
                        Console.WriteLine("Car is accelerating...");
                        break;
                    case "Brake":
                        Console.WriteLine("Car is braking...");
                        break;
                    case "Right":
                        Console.WriteLine("Car is turning right...");
                        break;
                }
            }
            else if (command == "Left")
            {
                Console.WriteLine("Error: Car cannot turn left.");
            }
            else
            {
                Console.WriteLine($"Error: '{command}' is an invalid command.");
            }
        }
    }
}
