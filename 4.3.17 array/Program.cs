using System;
using System.Security.Cryptography.X509Certificates;

namespace mynamespase
{
    class program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;
            for (int k = 0; k < arr.GetLength(0) + 1; k++)
            {

                for (int i = 0; i < arr.GetUpperBound(1) + 1; i++)
                {

                    for(int j = i + 1; j < arr.GetUpperBound(1) + 1; j++)
                    {
                        
                        if (arr[k,i] > arr[k, j])
                        {
                            temp = arr[k, j];
                            arr[k,j] = arr[k,i];
                            arr[k,i] = temp;
                        }
                    }
                    Console.Write(arr[k,i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
