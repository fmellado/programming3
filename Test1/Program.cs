using System;

namespace Test1Question1
{
    class Program
    {
        public delegate double ArithmeticOperation(double x, double y);

        public class Calculator
        {

           public double PerformOperation(double x, double y, ArithmeticOperation operation)
            {
                return operation(x, y);
            }

            static void Main(string[] args)

            {
                Calculator calculator = new Calculator();

                // Lambda expressions for arithmetic operations
                ArithmeticOperation add = (x, y) => x + y;
                ArithmeticOperation subtract = (x, y) => x - y;
                ArithmeticOperation div = (x, y) => x / y;
                ArithmeticOperation mult = (x, y) => x * y;

                Console.WriteLine("Enter value x: ");
                double x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second value y: ");
                double y = Double.Parse(Console.ReadLine());

                Console.WriteLine($"Addition: {calculator.PerformOperation(x, y, add)}");
                Console.WriteLine($"Subtraction: {calculator.PerformOperation(x, y, subtract)}");
                Console.WriteLine($"Multiplication: {calculator.PerformOperation(x, y, mult)}");
                Console.WriteLine($"Division: {calculator.PerformOperation(x, y, div)}");



                /* double result1 = add(5, 3);
                 double result2 = subtract(8, 2);
                 double result3 = div(10, 4);
                 double result4 = mult(10, 5);

                 Console.WriteLine("Addition Result: " + result1);
                 Console.WriteLine("Substraction Result: " + result2);
                 Console.WriteLine("Division Result: " + result3);
                 Console.WriteLine("Multiplication Result: " + result4);
                 Console.ReadLine();*/
                //2.Complete the code, use Lambda expressions  with Delegates(7 points )

                // Example: addition = (x, y) => x + y



            }



        }

    }
}
