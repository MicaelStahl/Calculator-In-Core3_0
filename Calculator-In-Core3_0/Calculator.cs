using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_In_Core3_0
{
    class Calculator
    {
        public void CalculatorBody()
        {
            Display display = new Display();
            Calculations calculations = new Calculations();
            var stayAlive = true;
            int? totalResponse = 0;

            Console.Clear();

            try
            {
                display.DisplayMessage("Please pick your first number in the equation!");
                var firstNumber = Convert.ToInt32(Console.ReadLine());

                display.DisplayMessage("Thank you! /t Now please pick your operator for the equation!");
                var operater = Convert.ToChar(Console.ReadLine());

                if (operater == '+' || operater == '-')
                {
                    while (stayAlive)
                    {
                        display.DisplayMessage(
                                totalResponse == 0 
                                ? "Please pick your other number to continue the equation!"
                                : $"Your number is currently {totalResponse}, please pick another number to continue the equation!");
                        var secondNumber = Convert.ToInt32(Console.ReadLine());

                        var response = calculations.Calculation(firstNumber, operater, secondNumber);

                        totalResponse += response;

                        display.DisplayMessage($"The answer to the equation is {response}!", ConsoleColor.Green);
                        display.DisplayMessage("Do you wish to continue the equation? y/n");

                        var continueEquation = Convert.ToChar(Console.ReadLine());

                        switch (continueEquation)
                        {
                            case 'y':
                                Console.Clear();
                                break;
                            case 'n':
                                stayAlive = false;
                                break;
                            default:
                                throw new InvalidCastException($"{continueEquation} is not a valid choice!");
                        }
                    }
                }

            }
            catch (InvalidCastException ex)
            {
                display.DisplayMessage(ex.Message, ConsoleColor.Red);
            }
            catch (Exception)
            {
                display.DisplayMessage("Something went wrong, please try again");
            }
        }
    }
}
