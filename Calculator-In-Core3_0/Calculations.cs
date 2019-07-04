using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_In_Core3_0
{
    class Calculations
    {
        public int? Calculation(int? firstNumber, char operater, int? secondNumber)
        {
            Display display = new Display();
            try
            {
                if (firstNumber == null || secondNumber == null)
                {
                    throw new FormatException();
                }

                if (operater == '+' || operater == '-')
                {
                    return (int)(firstNumber + operater + secondNumber);
                }
                else if (operater == '*')
                {
                    if (firstNumber <= 0 || secondNumber <= 0)
                    {
                        throw new ArgumentException("You cannot multiply with 0, Please try something else");
                    }
                    else
                    {
                        return (int)(firstNumber + operater + secondNumber);
                    }
                }
                else if (operater == '/')
                {
                    if (firstNumber <= 0 || secondNumber <= 0)
                    {
                        throw new ArgumentException("You cannot divite with 0, Please try something else");
                    }
                    else
                    {
                        return (int)(firstNumber + operater + secondNumber);
                    }
                }
                else
                {
                    throw new Exception("A valid operator was not picked. Please try again");
                }
            }
            catch (FormatException ex)
            {
                display.DisplayMessage($"Something went wrong. The error was {ex.ToString()}.", ConsoleColor.Red);
                throw;
            }
            catch (ArgumentException ex)
            {
                display.DisplayMessage(ex.Message, ConsoleColor.Red);
                throw;
            }
            catch (Exception ex)
            {
                display.DisplayMessage(ex.Message ?? "Something went wrong", ConsoleColor.Red);
                throw;
            }
        }
    }
}
