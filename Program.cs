using System;
namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------Method-1-------------------------------------------------------
            // int a = 1, b = 22;
            Console.WriteLine("Please enter lower and upper integer limit for printSelfDividingNumbers method:");
            Console.Write("Please enter lower integer limit for printSelfDividingNumbers method: ");
            // This variable will gather data from user input
            string lower_lim = Console.ReadLine();
            Console.Write("Please enter upper integer limit for printSelfDividingNumbers method: ");
            // This variable will gather data from user input
            string upper_lim = Console.ReadLine();
            printSelfDividingNumbers(Convert.ToInt32(lower_lim), Convert.ToInt32(upper_lim));
            Console.Write("\n");
            //----------------------------------Method-2-------------------------------------------------------
            int n2 = 5;
            Console.Write("Please enter an integer number n2 for printSeries method: ");
            // This variable will gather data from user input
            string input2 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value2 = int.Parse(input2);
            printSeries(input_value2);
            Console.Write("\n");
            //----------------------------------Method-3-------------------------------------------------------
            //int n3 = 5;
            Console.Write("Please enter an integer number n3 for printTriangle method: ");
            // This variable will gather data from user input
            string input3 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value3 = int.Parse(input3);
            printTriangle(input_value3);
            Console.Write("\n");
            //----------------------------------Method-4-------------------------------------------------------
            //int[] J = new int[] { 1, 3 };
            //int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            Console.Write("Please enter how many types of Jeweles in Array J[] numJewelsInStones method: ");
            // This variable will gather data from user input
            string input4 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value4 = int.Parse(input4);
            Console.Write("Please enter how many types of Stones you have in Array S[] numJewelsInStones method:: ");
            // This variable will gather data from user input
            string input5 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value5 = int.Parse(input5);

            int[] J = new int[input_value4];
            int[] S = new int[input_value5];
            int J_lenght = input_value4;
            int S_lenght = input_value5;

            input_array(J, S, J_lenght, S_lenght);
            int r4 = numJewelsInStones(J, S, J_lenght, S_lenght);
            Console.WriteLine(r4);
            Console.Write("\n");
            //----------------------------------Method-5-------------------------------------------------------
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

            /*Console.Write("Please enter lenghth of array_1: ");
            // This variable will gather data from user input
            string input6 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value6 = int.Parse(input6);
            Console.Write("Please enter lenghth of array_2: ");
            // This variable will gather data from user input
            string input7 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value7 = int.Parse(input7);

            int[] arr1 = new int[input_value6];
            int[] arr2 = new int[input_value7];
            int arr1_lenght = input_value6;
            int arr2_lenght = input_value7;

            input_array(arr1, arr2, arr1_lenght, arr2_lenght);*/
            //int[] r5 = getLargestCommonSubArray(arr1, arr2, arr1_lenght, arr2_lenght);

            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);
            solvePuzzle();

        }
        //Method-1
        /* This method prints all the self-dividing numbers between x and y. 
         * A self-dividing number is a number that is divisible by every digit it contains.
         */
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                //rem will be used to store every digit in a number
                int m1 = 0;
                //Iterate through the numbers between x and y
                for (int i = x; i <= y; i++)
                {
                    //num will be used to input the self-dividing numbers
                    int n1 = i;
                    //div will be used to get every digit a number
                    int var1 = i;
                    //Print all the self.-dividing numbers using While loop
                    while (var1 != 0)
                    {
                        //After dividing by 10, get every digit by taking the remainder, for example: 128%10->8
                        m1 = var1 % 10;
                        //Remove the  multiple of 10
                        if (m1 == 0)
                            break;
                        //Remove the number that cannot be divisible by digit it contains
                        if (n1 % m1 != 0)
                            break;
                        //For example: 128/10->12; 12->1
                        var1 = var1 / 10;
                        //Input the self-dividing numbers
                        if (var1 == 0)
                            Console.Write(" " + n1);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }


        //------------------------------------------------------------------------------------------
        //Method-2
        public static void printSeries(int input_value2)
        {
            Console.Write("Please enter an intege number n: ");
            try
            {
                int input_val2 = input_value2;
                int counter_for_print = 0;
                for (int i = 1; i <= input_val2; i++)
                {
                    for (int j = 1; j <= i && (counter_for_print != input_val2); j++)
                    {
                        //This will display the printseries for any number user wanted
                        Console.Write(" " + i);
                        counter_for_print++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }
        //Method-3
        public static void printTriangle(int input_value3)
        {
            try
            {
                //write your code here 

                int line, counter, row_count = 0;
                int loop_counter = input_value3;

                for (line = 1; line <= loop_counter; line++, row_count = 0)
                {
                    //
                    for (counter = 1; counter <= line; counter++)
                    {
                        Console.Write(" ");
                    }
                    //this while loop will tell you the number of elements * to print in each row  
                    for (int n = line; n <= loop_counter; n++)
                    {
                        Console.Write("* ");
                        //  row_count++;
                    }
                    Console.Write("\n");

                    //this will print the result to next line
                    Console.WriteLine("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        //Method-4
        //This input_array method is used to take input for arrays Jewel J and Stone S from console 
        public static void input_array(int[] J, int[] S, int J_lenght, int S_lenght)
        {
            //This loop is to read the Jewel array from console
            Console.Write("Please enter elements of Jewel array J: ");
            for (int i = 0; i < J_lenght; i++)
            {
                J[i] = int.Parse(Console.ReadLine());
            }
            //This loop is to read the Stone array from console
            Console.Write("Please enter elements of Stone array S: ");
            for (int i = 0; i < S_lenght; i++)
            {
                S[i] = int.Parse(Console.ReadLine());
            }
            Console.Read();
        }
        public static int numJewelsInStones(int[] J, int[] S, int J_lenght, int S_lenght)
        {
            try
            {
                //write your code here
                int[] J_array = J;
                int[] S_array = S;
                //this count variable is used to take number of elements common in Stones from Jewel
                int count = 0;
                //outer for loop is used to read Jewel array
                for (int i = 0; i < J_lenght; i++)
                {
                    //this inner for loop is used to read Stones array
                    for (int j = 0; j < S_lenght; j++)
                    {
                        //this condition checks the common elements present in array Jewel and Stone
                        if (J_array[i] == S_array[j])
                        {
                            count++;
                        }
                        else
                        {
                            //count = 0;
                            //break;
                        }
                    }
                }
                if (count != 0)
                {
                    //this will tell you the number of stones that are Jewels too:
                    Console.Write("You have {0} number of stones that are Jewels too: ", count);
                    return count;
                }
                else
                {
                    Console.Write("You don't have any Stones that are Jewels too:");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return 0;
        }
        //Method-5
        //public static int[] getLargestCommonSubArray(int[] a, int[] b,int arr1_lenght,int arr2_lenght)
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {


            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------------------------
        //Method-6
        public static void solvePuzzle()
        {
            try
            {

            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}