using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab
{
    internal class Program
    {
        //Variant 5
        /*Дана сукупність n цілих чисел, що являє собою координати точок на деякій
        координатній прямій. (Прямій, а не площині; тому, в кожної точки одна координата.)
        Знайдіть найменшу серед відстаней між різними точками. Наприклад, для вх. даних «2 7 1 8 2 8»
        правильною відповіддю є 1, бо повтори слід проігнорувати, а серед різних точок є точки з координатою 1 і координатою 2 (отже,
        відстанню 1 між ними), а також з координатою 7 і координатою 8 (отже, теж відстанню 1 між ними). Програма повинна вивести
        лише відповідь «мінімальна відстань 1» без подальших пояснень (але такі пояснення може питати викладач при захисті). */
        static int[] EnteringNumbers()
        {
            string[] input = Console.ReadLine().Trim().Split();
            int[] array = new int[input.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            return array;
        }
        static void Sort(int[] arr )
        {          
            int n = arr.Length;

            for (int i = 0; i < n-1; i++)
            {
                int t = 0;
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                                      
                }
                t = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = t;
            }          
        }
        static void Solution(int[] arr)
        {
            int MinDifference = int.MaxValue;
            int difference = int.MaxValue;
            for (int i = 0; i < arr.Length-1; i++)
            {                                            
                difference = arr[i + 1] - arr[i];
                if (difference < MinDifference && difference != 0 && MinDifference != 0)
                {
                    MinDifference = difference;
                }
                 
            }           
                Console.WriteLine(MinDifference);
                        
        }
        static void Main()
        {
            int[] numbers;
            numbers = EnteringNumbers();
            Sort(numbers);
            Solution(numbers);
        }
    }
}
