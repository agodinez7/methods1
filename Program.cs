using System;

namespace methods1
{
    class Program
    {
        static double FourBasicArithmeticOperations(double a, double b, int flag)
        {

            switch (flag)
            {

                case 1: return (a + b);

                case 2: return (a - b);

                case 3: return (a * b);

                case 4:
                    {

                        if (b == 0)
                            Console.WriteLine("Unable to divide by zero");
                        else
                            return (a / b);
                        break;
                    }
                default: break;
            }

            return double.NaN;
        }
        static void Main(string[] args)
        {

            double a, b;

            int flag;

            try
            {

                while (true)
                {
                    Console.WriteLine("Alex Godinez");
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Four Basic Arithmetic Operations");
                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide");
                    Console.WriteLine("Please select your choice and press enter");

                    flag = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The ouput of the arithmetic operation is " + FourBasicArithmeticOperations(a, b, flag));

                    Console.WriteLine("Do you want to continue? Y or N\n");

                    char ch = Console.ReadKey().KeyChar;
                    if (ch == 'y' || ch == 'Y')
                        continue;
                    else
                        break;
                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine("Please enter only integers\n" + ex.Message);
                Console.ReadKey();

            }
        }
    }
}
