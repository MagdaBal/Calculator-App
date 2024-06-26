﻿using System;

namespace homework_1
{
    internal class Program
    {
        // methods

        static double Addition(double a, double b)
        {
            return a + b;
        }

        static double Subtraction(double a, double b)
        {
            return a - b;
        }

        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("You can't devide by zero");
                return double.NegativeInfinity;
            }
        }

        static double Exponentiation(double a, double b)
        {
            return Math.Pow(a, b);
        }


        static double Factorial(int number)//-12
        {
            if (number == 0 || number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        static void Main(string[] args)
        {

            var x = 15;
            var y = 0;
            Console.WriteLine($"Result= {Division(x, y)}");


            double number1 = 0, number2 = 0;
            int operation = 0;

            do
            { 

                Console.WriteLine("This is the Calculator App");

                int flag2;
                do
                {
                    Console.Write("Enter the first number:");
                    try
                    {
                        number1 = Convert.ToDouble(Console.ReadLine());
                        flag2 = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        flag2 = 1;
                    }
                }
                while (flag2 == 1);

                int flag3;
                do
                {
                    Console.Write("Enter the second number:");
                    try
                    {
                        number2 = Convert.ToDouble(Console.ReadLine());
                        flag3 = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        flag3 = 1;
                    }
                }
                while (flag3 == 1);


                Console.WriteLine("Choose which math operation to perform:");  // choosing operation
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exponentiation");
                Console.WriteLine("6. Factorial");
                Console.WriteLine("7. Exit program");

                int flag = 1;
                do
                {
                    Console.Write("Enter the operation number: ");
                    try
                    {
                        operation = Convert.ToInt32(Console.ReadLine());
                        if(operation>0 && operation<8)
                        {
                            flag = 0;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //Console.WriteLine("Invalid input");
                        flag = 1;
                    }

                    
                }
                while (flag==1);



            
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Result= {number1} + {number2} = {Addition(number1, number2)}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Result= {number1} - {number2} = {Subtraction(number1, number2)}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Result= {number1} * {number2} = {Multiplication(number1, number2)}\n");
                        break;
                    case 4:
                        if (number2 != 0)
                            Console.WriteLine($"Result= {number1} / {number2} = {Division(number1, number2)}\n");
                        else
                            Console.WriteLine("You can't divide by zero!");
                        break;
                    case 5:
                        Console.WriteLine($"Result= {number1} ^ {number2} = {Exponentiation(number1, number2)}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Result= {number1}! = {Factorial((int)number1)}\n");
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
            }

            while (operation != 7);

        }
    }
}