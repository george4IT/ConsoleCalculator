using System;

namespace Calculator
{
    class Calculator
    {
        static double memory = 0;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Add to Memory");
                Console.WriteLine("6. Memory Recall");
                Console.WriteLine("7. Memory Clear");
                Console.WriteLine("8. Square");
                Console.WriteLine("9. Square Root");
                Console.WriteLine("10.Minus value(opposite value)");
                Console.WriteLine("11. Exit");
                Console.WriteLine();

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                int choice;
                if (int.TryParse(choice, out option))
                {
                    switch (option)
                    {
                        case 1:
                            Add();
                            break;
                        case 2:
                            Subtract();
                            break;
                        case 3:
                            Multiply();
                            break;
                        case 4:
                            Divide();
                            break;
                        case 5:
                            ToMemory();
                            break;
                        case 6:
                            RecallFromMemory();
                            break;
                        case 7:
                            ClearMemory();
                            break;
                        case 8:
                            Square();
                            break;
                        case 9:
                            SquareRoot();
                            break;
                        case 10:
                             MinusValue();
                            break;
                        case 11:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    
                }
            }
        }

        static double GetNumber(string message)
        {
            double number;
            bool valid = false;

            do
            {
                Console.Write(message);
                number = Convert.ToDouble(Console.ReadLine());

                if (!Double.IsNaN(number))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine();
                }
            } while (!valid);

            return number;
        }

        static void Add()
        {
            double num1 = GetNumber("Enter the first number: ");
            double num2 = GetNumber("Enter the second number: ");
            double result = num1 + num2;

            Console.WriteLine("Result: " + result);
        }

        static void Subtract()
        {
            double num1 = GetNumber("Enter the first number: ");
            double num2 = GetNumber("Enter the second number: ");
            double result = num1 - num2;

            Console.WriteLine("Result: " + result);
        }

        static void Multiply()
        {
            double num1 = GetNumber("Enter the first number: ");
            double num2 = GetNumber("Enter the second number: ");
            double result = num1 * num2;

            Console.WriteLine("Result: " + result);
        }

        static void Divide()
        {
            double num1 = GetNumber("Enter the first number: ");
            double num2 = GetNumber("Enter the second number: ");

            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }

            double result = num1 / num2;

            Console.WriteLine("Result: " + result);
        }

        static void ToMemory()
        {
            double num = GetNumber("Enter the number to store in memory: ");
            memory = num;

            Console.WriteLine("Number stored in memory.");}

        static void RecallFromMemory()
        {
            Console.WriteLine("Memory value: " + memory);
        }

        static void ClearMemory()
        {
            memory = 0;

            Console.WriteLine("Memory cleared.");
        }

        static void Square()
        {
            double num1 = GetNumber("Enter the first number: ");
            double result = Math.Pow(num1,2);

            Console.WriteLine("Sqare power of {0} = {1}.", num1, result);
        }

        static void SquareRoot()
        {
            double num1 = GetNumber("Enter the first number: ");
            double result = Math.Sqrt(num1);

            Console.WriteLine("Sqare root of {0} = {1}.", num1, result);
        }

        static void MinusValue()
        {
            double num1 = GetNumber("Enter the first number: ");
            double result = num1 * (-1.0);
            Console.WriteLine("Result = " + result);
        }


    }
}