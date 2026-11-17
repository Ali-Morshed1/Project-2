using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
namespace ConsoleApp3;

class Project
{
    static void Main(string[] argv)
    {
        //                            C# Exception Handling Exercises
        // User_input_division_with_exception_handling(); // 1
        // Negative_number_exception_handling(); // 2
        // File_opening_with_exception_handling(); // 3
        // Numeric_and_integer_input_validation(); // 4
        // Calculate_the_average_of_integers_in_an_array(); // 5
        // Convert_user_input_string_to_integer_with_exception_handling(); // 6
        // Read_and_handle_Int32_range_exceptions_in_user_input(); // 7
        // Divide_two_numbers_with_exception_handling(); // 8
        // Calculate_square_root_with_exception_handling(); // 10
        // Convert_string_to_uppercase_with_exception_handling(); // 11
    }
    // Question 1
    static void User_input_division_with_exception_handling()
    {
        double? int1;
        double? int2;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter The First Number");
                int1 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter The Sec Number");
                int2 = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine($"{int1} / {int2} = {int1 / int2}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 2
    static void Negative_number_exception_handling()
    {
        double? num;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Non Negative Number");
                num = Convert.ToDouble(Console.ReadLine());
                if (num > 0)
                {
                    System.Console.WriteLine("Correct");
                    break;
                }
                System.Console.WriteLine("Please Enter A Number Greater Than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 3
    static void File_opening_with_exception_handling()
    {
        string? path;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter The Path Of Your File:");
                path = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(path))
                    System.Console.WriteLine("Please Enter A Path");
                else if (!File.Exists(path))
                    System.Console.WriteLine("Path Doesn't Exist");
                else if (File.Exists(path))
                {
                    System.Console.WriteLine(File.OpenRead(path));
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid String");
            }
        }
    }
    // Question 4
    static void Numeric_and_integer_input_validation()
    {
        double? num;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number Bigger Than 0 & Smaller Than 1000");
                num = Convert.ToDouble(Console.ReadLine());
                if (num <= 0 || num >= 1000)
                    System.Console.WriteLine("Please A Number Greater Than 0 Or A Number Smaller Than 1000");
                else
                {
                    System.Console.WriteLine("Correct!");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 5
    static void Calculate_the_average_of_integers_in_an_array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.Write($"Enter element for index [{i}]:");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        int Average = 0;
        for (int i = 0; i < length; i++)
            Average += ints[i];
        Average /= length;
        System.Console.WriteLine($"The Average Number Of Your Array Is: {Average}");

    }
    // Question 6
    static void Convert_user_input_string_to_integer_with_exception_handling()
    {
        string? input;
        int Converted;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number (String) To Convert To Int");
                input = Console.ReadLine();
                Converted = Convert.ToInt32(input);
                System.Console.WriteLine($"Converted To Int: {Converted}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 7
    static void Read_and_handle_Int32_range_exceptions_in_user_input()
    {
        int? num;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number Between [-2,147,483,647 & 2,147,483,647] (The Minimum/Maximum Value Of Int32)");
                num = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Correct!");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Number Between [-2,147,483,647 & 2,147,483,647]");
            }
        }
    }
    // Question 8
    static void Divide_two_numbers_with_exception_handling()
    {
        double? num1;
        double? num2;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter Number 1");
                num1 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter Number 2");
                num2 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Please Make Number 2 Bigger Than 0");
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 10
    static void Calculate_square_root_with_exception_handling()
    {
        double num;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number To Get It's Square Root");
                num = Convert.ToDouble(Console.ReadLine());
                if (num < 0)
                    System.Console.WriteLine("Please Enter A Number Bigger Or Equal Than 0");
                else
                {
                    System.Console.WriteLine($"Square Root = {Math.Sqrt(num)}");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 11
    static void Convert_string_to_uppercase_with_exception_handling()
    {
        string? input;
        string placeholder = "";
        do
        {
            System.Console.WriteLine("Enter A Random String To Convert It To Uppercase");
            input = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(input))
                placeholder = input.ToUpper();
        } while (string.IsNullOrWhiteSpace(input));
        System.Console.WriteLine($" Before :{input}");
        System.Console.WriteLine($" After  :{placeholder}");
    }
}