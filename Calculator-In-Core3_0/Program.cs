using System;

namespace Calculator_In_Core3_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();

            var stayAlive = true;
            display.DisplayMessage("Hello! This is the recreation of week 1 assignment, Calculator in Core 3.0.");

            do
            {
                try
                {
                    display.DisplayMessage("Please either press 1 to continue to the calculator, or press 0 to exit the application.");
                    char keyPress = Convert.ToChar(Console.ReadKey(true));

                    switch (keyPress)
                    {
                        case '1':
                            display.DisplayMessage("You're no wimp I see! proceed to the calculator by pressing a key...");
                            Console.ReadLine();
                            break;

                        case '0':
                            stayAlive = false;
                            break;

                        default:
                            throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    display.DisplayMessage("Please enter a valid option.", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    display.DisplayMessage("Something went wrong. Please try again");
                }
            }
            while (stayAlive);
        }
    }
}
