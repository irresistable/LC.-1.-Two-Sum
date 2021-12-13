using System;
using System.Collections.Generic;

namespace LC._1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test test = new();
            //test.Testing(new int[] {1,2,3,4,5 }, 3);
            TwoSum twoSum = new();
            int [] result;
            try
            {
                result = twoSum.ResultTwoSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 18);
                Console.WriteLine("result");
                foreach (var item in result)
                {
                    Console.Write($"{item} ");
                }
            }
            catch (Exception exeption)
            {
                Console.WriteLine($"\nError is: { exeption.Message}");
            }
        }
    }
    public class Test
    {
        public void Testing(int [] test, int testTarget)
        {
            Dictionary<int, int> testDicKey = new();
            for (int i = 0; i < test.Length; i++)
            {
                testDicKey.Add(test[i], i);
            }
            int value;
            bool check = testDicKey.TryGetValue(testTarget, out value);
            if (check)
            {
                Console.WriteLine($"{testTarget} found at index {value}");
            }
            else
                {
                Console.WriteLine($"{testTarget} not found");
            }
        }
    }


    public class TwoSum
    {
        public int[] ResultTwoSum(int[] sourceNumbers, int targetNumber)
        {
            Dictionary<int, int> hashDic = new();
            int difference;
            for (int i = 0; i < sourceNumbers.Length; i++)
            {
                difference = targetNumber - sourceNumbers[i];
                Console.WriteLine($"index is {i}, array at {i} is {sourceNumbers[i]}, difference is {difference}");
                int indexFound;
                bool check = hashDic.TryGetValue(difference, out indexFound);
                if (check)
                {
                    Console.WriteLine($"found that {sourceNumbers[i]} + {difference} = {targetNumber}");
                    Console.WriteLine($"indexFound is {indexFound}");
                    Console.WriteLine($"corresponding indexes are {hashDic[difference]} and {i} ");
                    return new int[]{ hashDic[difference], i};
                }
                else
                {
                    hashDic.Add(sourceNumbers[i],i);
                    Console.WriteLine($"Key {sourceNumbers[i]} added with value {i}");
                }
            }
            throw new Exception("No Solution found");
        }
    }

    

}
