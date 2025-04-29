using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        Console.WriteLine($"The min is: {min}");
         
        //int small_pos = numbers[0];

        //foreach(int number in numbers)
        //{
            //if (number > 0)
            //{
                //if (number < small_pos) 
                //{
                    //small_pos = number;
                //}
            //}
        //}

        //Console.WriteLine($"The smallest postive number is: {small_pos}");
        
    }
}