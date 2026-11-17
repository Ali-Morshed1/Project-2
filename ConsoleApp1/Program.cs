using System;
namespace ConsoleApp1;
class Project
{
    static void Main(string[] argv)
    {
        //                                     C# Basic Exercises
        // Get_the_larger_value_between_first_and_last_element_of_an_array_of_integers(); // 1
        // Create_an_array_containing_the_middle_elements_of_three_arrays_of_integers(); // 2
        // Check_if_an_array_contains_an_odd_number(); // 3
        // Get_the_century_from_a_year(); // 4
        // Find_the_pair_of_adjacent_elements_that_has_the_largest_product_of_an_given_array_which_is_equal_to_a_given_value(); // 5 // Same Question?
        // Check_if_a_given_string_is_a_palindrome_or_not(); // 6
        // Find_the_pair_of_adjacent_elements_that_has_the_highest_product_of_an_given_array_of_integers(); // 7 // Same Question?
        // Checks_how_many_integers_are_needed_to_complete_the_range(); // 8
        // Check_whether_it_is_possible_to_create_a_strictly_increasing_sequence_from_a_given_sequence_of_integers_as_an_array(); // 9
        // Calculate_the_sum_of_all_the_integers_of_a_rectangular_matrix_except_those_integers_which_are_located_below_an_intger_of_value_0(); // 10
    }
    // Question 1
    static void Get_the_larger_value_between_first_and_last_element_of_an_array_of_integers()
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
        if (ints[0] > ints[ints.Length - 1])
            System.Console.WriteLine($"first index (0) > Last Index = {ints[0]} > {ints[ints.Length - 1]}");
        else if (ints[0] < ints[ints.Length - 1])
            System.Console.WriteLine($"Last Index > first index (0) = {ints[ints.Length - 1]} > {ints[0]}");
        else
            System.Console.WriteLine($"first index (0) = Last index = {ints[0]} = {ints[ints.Length - 1]}");
    }
    // Question 2
    static void Create_an_array_containing_the_middle_elements_of_three_arrays_of_integers()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the First array");
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

        int length2 = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the sec array");
                length2 = Convert.ToInt32(Console.ReadLine());
                if (length2 > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints2 = new int[length2];

        for (int i = 0; i < ints2.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.Write($"Enter element for index [{i}]:");
                    ints2[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int length3 = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the third array");
                length3 = Convert.ToInt32(Console.ReadLine());
                if (length3 > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints3 = new int[length3];

        for (int i = 0; i < ints3.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.Write($"Enter element for index [{i}]:");
                    ints3[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int[] middleElements = new int[3];
        middleElements[0] = ints[ints.Length / 2];
        middleElements[1] = ints2[ints2.Length / 2];
        middleElements[2] = ints3[ints3.Length / 2];
        System.Console.WriteLine("\nNew array containing the middle elements:");
        for (int i = 0; i < middleElements.Length; i++)
            System.Console.Write(middleElements[i] + " ");
        System.Console.WriteLine();

    }
    // Question 3
    static void Check_if_an_array_contains_an_odd_number()
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

        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] % 2 != 0)
            {
                System.Console.WriteLine("True It Contains An Odd Number");
                break;
            }
            else
            {
                System.Console.WriteLine("False It Doesn't Contain An Odd Number");
                break;
            }
        }
    }
    // Question 4
    static void Get_the_century_from_a_year()
    {
        int year = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Random Century");
                year = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        int century = (int)Math.Ceiling((double)year / 100);
        System.Console.WriteLine($"The Century Of {year} is {century}");
    }
    // Question 5 // Same Question?
    static void Find_the_pair_of_adjacent_elements_that_has_the_largest_product_of_an_given_array_which_is_equal_to_a_given_value()
    {
        int size = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of elements to be stored in the array (minimum 2):");
                size = Convert.ToInt32(Console.ReadLine());
                if (size >= 2) break;
                Console.WriteLine("Please enter a number greater than or equal to 2.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        int[] arr = new int[size];

        Console.WriteLine($"\nInput {size} elements in the array :");
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        int maxProduct = arr[0] * arr[1];
        int firstElement = arr[0];
        int secondElement = arr[1];

        for (int i = 1; i < size - 1; i++)
        {
            int currentProduct = arr[i] * arr[i + 1];

            if (currentProduct > maxProduct)
            {
                maxProduct = currentProduct;
                firstElement = arr[i];
                secondElement = arr[i + 1];
            }
        }

        Console.WriteLine($"\nThe pair of adjacent elements with the largest product is: {firstElement} and {secondElement}");
        Console.WriteLine($"The largest product value is: {maxProduct}");
    }
    // Question 6
    static void Check_if_a_given_string_is_a_palindrome_or_not()
    {
        string? input;
        string cleanString;
        do
        {
            Console.WriteLine("Enter a string to check if it is a palindrome:");
            input = Console.ReadLine();
            cleanString = input.ToLower();
        } while (string.IsNullOrWhiteSpace(input));
        bool isPalindrome = true;
        int left = 0;
        int right = cleanString.Length - 1;
        while (left < right)
        {
            if (cleanString[left] != cleanString[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        if (isPalindrome)
            Console.WriteLine($"\"{input}\" is a palindrome.");
        else
            Console.WriteLine($"\"{input}\" is NOT a palindrome.");

    }
    // Question 7 // Same Question?
    static void Find_the_pair_of_adjacent_elements_that_has_the_highest_product_of_an_given_array_of_integers()
    {
        int size = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of elements to be stored in the array (minimum 2):");
                size = Convert.ToInt32(Console.ReadLine());
                if (size >= 2) break;
                Console.WriteLine("Please enter a number greater than or equal to 2.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        int[] arr = new int[size];
        Console.WriteLine($"\nInput {size} elements in the array :");
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
        int maxProduct = arr[0] * arr[1];
        int firstElement = arr[0];
        int secondElement = arr[1];
        for (int i = 1; i < size - 1; i++)
        {
            int currentProduct = arr[i] * arr[i + 1];
            if (currentProduct > maxProduct)
            {
                maxProduct = currentProduct;
                firstElement = arr[i];
                secondElement = arr[i + 1];
            }
        }
        Console.WriteLine($"\nThe pair of adjacent elements with the highest product is: {firstElement} and {secondElement}");
        Console.WriteLine($"The highest product value is: {maxProduct}");
    }
    // Question 8
    static void Checks_how_many_integers_are_needed_to_complete_the_range()
    {
        int size = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of elements to be stored in the array :");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 0) break;
                Console.WriteLine("Please enter a number greater than 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        int[] arr = new int[size];
        Console.WriteLine($"\nInput {size} elements in the array :");
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }
        int totalNeededNumbers = (max - min) + 1;
        int missingNumbersCount = totalNeededNumbers - size;
        Console.WriteLine($"\nNumber of elements needed to complete the range: {missingNumbersCount}");
    }
    // Question 9
    static void Check_whether_it_is_possible_to_create_a_strictly_increasing_sequence_from_a_given_sequence_of_integers_as_an_array()
    {
        int size = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of elements to be stored in the array :");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 0) break;
                Console.WriteLine("Please enter a number greater than 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        int[] arr = new int[size];
        Console.WriteLine($"\nInput {size} elements in the array :");
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
        bool RightorNot = false;
        for (int i = 0; i < size - 1; i++)
        {
            if (arr[i] < arr[i + 1])
                RightorNot = true;
            else
            {
                RightorNot = false;
                break;
            }
        }
        System.Console.WriteLine(RightorNot);
    }
    // Question 10
    static void Calculate_the_sum_of_all_the_integers_of_a_rectangular_matrix_except_those_integers_which_are_located_below_an_intger_of_value_0()
    {
        int rows = 0;
        int cols = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of rows for the matrix:");
                rows = Convert.ToInt32(Console.ReadLine());
                if (rows > 0) break;
                Console.WriteLine("Please enter a number greater than 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of columns for the matrix:");
                cols = Convert.ToInt32(Console.ReadLine());
                if (cols > 0) break;
                Console.WriteLine("Please enter a number greater than 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        int[,] matrix = new int[rows, cols];
        Console.WriteLine($"\nInput elements for a {rows}x{cols} matrix:");
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                while (true)
                {
                    try
                    {
                        Console.Write($"element - [{r},{c}] : ");
                        matrix[r, c] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
        int totalSum = 0;
        for (int c = 0; c < cols; c++)
            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, c] == 0)
                    break;
                totalSum += matrix[r, c];
            }
        Console.WriteLine($"\nThe sum of elements excluding those below 0 is: {totalSum}");
    }
}
