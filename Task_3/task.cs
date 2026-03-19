using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] sourceNumbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        int positiveCount = 0;

        foreach (int number in sourceNumbers)
        {
            if (number > 0)
            {
                positiveCount++;
            }
        }
        Console.WriteLine($"Число элементов больше нуля: {positiveCount}");
        
        //2
        
        int[] numbersToReverse = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
             
        int length = numbersToReverse.Length; 
        int middle = length / 2;          
        int swapTemp; 
        
        for (int i = 0; i < middle; i++)
        {
            swapTemp = numbersToReverse[i];
            numbersToReverse[i] = numbersToReverse[length - i - 1];
            numbersToReverse[length - i - 1] = swapTemp;
        }
        
        foreach (int val in numbersToReverse)
        {
            Console.Write($"{val} \t");
        }
        Console.WriteLine();
        
        //3
        
        int[] unsortedArray = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
 
        int sortTemp;
        for (int i = 0; i < unsortedArray.Length - 1; i++)
        {
            for (int j = i + 1; j < unsortedArray.Length; j++)
            {
                if (unsortedArray[i] > unsortedArray[j])
                {
                    sortTemp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = sortTemp;
                }
            }
        }
         
        Console.WriteLine("Вывод отсортированного массива:");
        foreach (int element in unsortedArray)
        {
            Console.WriteLine(element);
        }
    }
}