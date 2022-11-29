using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private Controller controller;

    public Engine(Controller controller)
    {
        this.controller = controller;
    }

    public void Run()
    {
        string command;
        do
        {
            command = Console.ReadLine();
            List<string> splittedCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string commandType = splittedCommand[0];
            List<string> args = splittedCommand.Skip(1).ToList();

            string commandOutput = "";
            switch (commandType)
            {
                case "Product":
                    commandOutput = controller.ProcessProductCommand(args);
                    break;
                case "Service":
                    commandOutput = controller.ProcessServiceCommand(args);
                    break;
                case "Checkout":
                    commandOutput = controller.ProcessCheckoutCommand(args);
                    break;
                case "Info":
                    commandOutput = controller.ProcessInfoCommand(args);
                    break;
                case "End":
                    commandOutput = controller.ProcessEndCommand();
                    break;
            }

            Console.WriteLine(commandOutput);
        } while (command != "End");
    }
}
