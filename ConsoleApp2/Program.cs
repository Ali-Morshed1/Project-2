using System;
namespace ConsoleApp2;
class Project
{
    static void Main(string[] argv)
    {
        // C# Array Exercises
        // Read_and_Print_elements_of_an_array(); // 1
        // Read_n_number_of_values_in_an_array_and_display_it_in_reverse_order(); // 2
        // Find_the_sum_of_all_elements_of_array(); // 3
        // Copy_the_elements_one_array_into_another_array(); // 4
        // Count_a_total_number_of_duplicate_elements_in_an_array(); // 5
        // print_all_unique_elements_of_an_array(); // 6
        // Merge_two_arrays_of_same_size_sorted_in_ascending_order(); // 7
        // Count_frequency_of_each_element_of_an_array(); // 8
        // Find_maximum_and_minimum_element_in_an_array(); // 9
        // Separate_odd_and_even_integers_in_separate_arrays(); // 10
    }
    // Question 1
    static void Read_and_Print_elements_of_an_array()
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
        System.Console.WriteLine("The Elements In The Array Are:");
        foreach (int i in ints)
            System.Console.WriteLine(i);

    }
    // Question 2
    static void Read_n_number_of_values_in_an_array_and_display_it_in_reverse_order()
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
        Array.Reverse(ints);
        System.Console.WriteLine("The Elements In Your Custom Array Reversed:");
        foreach (int i in ints)
            System.Console.WriteLine(i);
    }
    // Question 3
    static void Find_the_sum_of_all_elements_of_array()
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
        foreach (int i in ints)
            total += i;
        System.Console.WriteLine($"The Total Sum Of Your Array Is {total}");
    }
    // Question 4
    static void Copy_the_elements_one_array_into_another_array()
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
        int[] ints1 = new int[length];
        Array.Copy(ints, ints1, length);
        System.Console.WriteLine("Created A New Copied Array Of The Original One:");
        System.Console.WriteLine(ints1);
        System.Console.WriteLine("The Elements Inside Are:");
        foreach (int i in ints1)
            System.Console.WriteLine(i);
    }
    // Question 5
    static void Count_a_total_number_of_duplicate_elements_in_an_array()
    {
        {
            int length = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the size of the array");
                    length = Convert.ToInt32(Console.ReadLine());
                    if (length > 0) break;
                    Console.WriteLine("Please enter a number greater than 0");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter A Valid Number");
                }
            }

            int[] ints = new int[length];

            for (int i = 0; i < ints.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Enter element for index [{i}]");
                        ints[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                    }
                }
            }
            bool[] alreadyCounted = new bool[length];
            int totalDuplicateNumbers = 0;

            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                if (alreadyCounted[i])
                    continue;

                int count = 1;
                for (int j = i + 1; j < length; j++)
                    if (ints[i] == ints[j])
                    {
                        count++;
                        alreadyCounted[j] = true;
                    }

                if (count > 1)
                {
                    Console.WriteLine($"Number {ints[i]} was duped {count} times");
                    totalDuplicateNumbers++;
                }
            }

            Console.WriteLine($"\nTotal number of duplicate elements found in the array is : {totalDuplicateNumbers}");
        }
    }
    // Question 6
    static void print_all_unique_elements_of_an_array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        Console.WriteLine("\nThe unique elements found in the array are:");
        for (int i = 0; i < ints.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < ints.Length; j++)
                if (ints[i] == ints[j])
                    count++;
            if (count == 1)
                Console.Write(ints[i] + " ");
        }
    }
    // Question 7
    static void Merge_two_arrays_of_same_size_sorted_in_ascending_order()
    {
        int size = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Input the number of elements to be stored in each array:");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 0) break;
                Console.WriteLine("Please enter a number greater than 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        int[] arr1 = new int[size];
        int[] arr2 = new int[size];
        int[] merged = new int[size * 2];

        Console.WriteLine($"\nInput {size} elements in the first array:");
        for (int i = 0; i < size; i++)
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

        Console.WriteLine($"\nInput {size} elements in the second array:");
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr2[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
        int index = 0;
        for (int i = 0; i < size; i++)
        {
            merged[index] = arr1[i];
            index++;
        }
        for (int i = 0; i < size; i++)
        {
            merged[index] = arr2[i];
            index++;
        }
        for (int i = 0; i < merged.Length - 1; i++)
            for (int j = 0; j < merged.Length - i - 1; j++)
                if (merged[j] > merged[j + 1])
                {
                    int temp = merged[j];
                    merged[j] = merged[j + 1];
                    merged[j + 1] = temp;
                }

        Console.WriteLine("\nThe merged array in ascending order is :");
        for (int i = 0; i < merged.Length; i++)
            Console.Write(merged[i] + " ");

        Console.WriteLine();
    }
    // Question 8
    static void Count_frequency_of_each_element_of_an_array()
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
        int[] freq = new int[size];

        Console.WriteLine($"\nInput {size} elements in the array :");
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"element - {i} : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    freq[i] = -1;
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        for (int i = 0; i < size; i++)
        {
            int count = 1;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    freq[j] = 0;
                }
            }

            if (freq[i] != 0)
            {
                freq[i] = count;
            }
        }

        Console.WriteLine("\nThe frequency of all elements of the array :");
        for (int i = 0; i < size; i++)
        {
            if (freq[i] != 0)
            {
                Console.WriteLine($"{arr[i]} occurs {freq[i]} times");
            }
        }
    }
    // Question 9
    static void Find_maximum_and_minimum_element_in_an_array()
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
        Console.WriteLine($"\nMaximum element is : {max}");
        Console.WriteLine($"Minimum element is : {min}");
    }
    // Question 10
    static void Separate_odd_and_even_integers_in_separate_arrays()
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
        int[] even = new int[size];
        int[] odd = new int[size];

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

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even[evenCount] = arr[i];
                evenCount++;
            }
            else
            {
                odd[oddCount] = arr[i];
                oddCount++;
            }
        }

        Console.WriteLine("\nThe Even elements are :");
        for (int i = 0; i < evenCount; i++)
        {
            Console.Write(even[i] + " ");
        }

        Console.WriteLine("\nThe Odd elements are :");
        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(odd[i] + " ");
        }
        Console.WriteLine();
    }
}