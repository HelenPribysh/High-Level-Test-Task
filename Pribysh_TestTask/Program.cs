using System;

namespace Pribysh_TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            ReturnSumArray(arr);
        }

        static int[] ReturnSumArray (int[] arr)
        {
            try
            {
                int count = 0;
                int[] sumArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {                    
                    sumArr[i] = count + arr[i];
                    count += arr[i];
                }

                foreach (var item in sumArr)
                {
                    Console.WriteLine(item);
                }

                return sumArr;                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new int[arr.Length];
            }
        }
    }
}
