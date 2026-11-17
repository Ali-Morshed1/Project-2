using System;
using System.ComponentModel;
namespace ConsoleApp4;
class Project
{
    static void Main(string[] argv)
    {
        //                     C# Function Exercises  
        Learn_how_to_create_a_user_define_function(); // 1
        // ------------------------------------------------------------------------
        string? input; // 2
        do
        {
            System.Console.WriteLine("Enter Your Name!");
            input = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(input));
        Learn_how_to_create_a_user_define_function_with_parameters(input);
        // ------------------------------------------------------------------------
        Function_to_calculate_the_sum_of_two_numbers(); // 3
        // ------------------------------------------------------------------------
        string? z; // 4
        do
        {
            System.Console.WriteLine("Enter A Random Sentence With Spaces And I Will Count The Spaces"); // 4
            z = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(z));
        Function_to_count_number_of_spaces_in_a_string(z);
        // ------------------------------------------------------------------------ 
        Calculate_the_sum_of_the_elements_in_an_array(); // 5
        // ------------------------------------------------------------------------
        double? x; // 6
        double? y;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        Function_To_swap_the_values_of_two_integer_numbers(x, y);
        // ------------------------------------------------------------------------
        To_calculate_the_result_of_raising_an_integer_number_to_another(); // 7
        // ------------------------------------------------------------------------
        int End; // 8
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number The Amount Of Loops You Want The Fibonacci Go For:");
                End = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        To_display_the_n_number_Fibonacci_sequence(End);
        // ------------------------------------------------------------------------
        double ok; // 9
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number The Amount Of Loops You Want The Fibonacci Go For:");
                ok = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        To_check_a_number_is_prime_or_not(ok);
        // ------------------------------------------------------------------------
        int zzz; // 10
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Random Number");
                zzz = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        SumOfDigits(zzz);
    }
    // Question 1
    static void Learn_how_to_create_a_user_define_function()
    {
        System.Console.WriteLine("Hello World");
    }
    // Question 2
    static void Learn_how_to_create_a_user_define_function_with_parameters(string x)
    {
        System.Console.WriteLine($"Hello, {x}");
    }
    // Question 3
    static void Function_to_calculate_the_sum_of_two_numbers()
    {
        double? num1;
        double? num2;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter The First Number");
                num1 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter The Second Number");
                num2 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 4
    static void Function_to_count_number_of_spaces_in_a_string(string z)
    {
        int Count = 0;
        for (int i = 0; i < z.Length; i++)
            if (z[i] == ' ')
                Count++;
        System.Console.WriteLine($"The Amount Of Spaces Appeared {Count} Times");
    }
    // Question 5
    static void Calculate_the_sum_of_the_elements_in_an_array()
    {
        int length = 0;
        int total = 0;
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
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        for (int i = 0; i < length; i++)
            total += ints[i];
        System.Console.WriteLine($"The Total Sum Of Your Array Is: {total}");
    }
    // Question 6
    static void Function_To_swap_the_values_of_two_integer_numbers(double? x, double? y)
    {
        double? swap;
        swap = x;
        x = y;
        y = swap;
        System.Console.WriteLine($"x:{x}");
        System.Console.WriteLine($"y:{y}");
    }
    // Question 7
    static void To_calculate_the_result_of_raising_an_integer_number_to_another()
    {
        double x;
        double y;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 8
    static void To_display_the_n_number_Fibonacci_sequence(int End)
    {
        int Count = 0;
        int x = 0;
        int y = 1;
        int z = 0;
        while (Count < End)
        {
            z = x + y;
            System.Console.WriteLine($"{x} + {y} = {z}");
            x = y;
            y = z;
            Count++;
        }
    }
    // Question 9
    static void To_check_a_number_is_prime_or_not(double x)
    {
        if (x <= 1)
        {
            Console.WriteLine("False");
            return;
        }

        if (x <= 3)
        {
            Console.WriteLine("True");
            return;
        }

        if (x % 2 == 0 || x % 3 == 0)
        {
            Console.WriteLine("False");
            return;
        }

        for (int i = 5; i * i <= x; i += 6)
        {
            if (x % i == 0 || x % (i + 2) == 0)
            {
                Console.WriteLine("False");
                return;
            }
        }

        Console.WriteLine("True");
    }
    // Question 10
    static int SumOfDigits(int zzz)
    {
        int sum = 0;
        zzz = Math.Abs(zzz);
        while (zzz > 0)
        {
            int lastDigit = zzz % 10;
            sum += lastDigit;
            zzz /= 10;
        }
        return sum;
    }
}
