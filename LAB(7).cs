using System;
using System.Collections.Generic;

namespace LAB_8_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            do
            {
                Console.Write("Enter size of List : ");
                size = int.Parse(Console.ReadLine());
                if (size <= 0)
                    Console.WriteLine("Error.Try again.");
            } while (size <= 0);
            List<int> binary = new List<int>(size);

            int Buff;
            int countNull = 0;
            int countOne = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter " + i + " number : ");
                Buff = int.Parse(Console.ReadLine());
                if (Buff == 0 || Buff == 1)
                {
                    if (Buff == 1)
                    {
                        countOne++;
                    }
                    else if (Buff == 0)
                    {
                        countNull++;
                    }
                    binary.Add(Buff);
                }
                else
                {
                    Console.WriteLine("Error . Enter number 1 or 0");
                    i--;
                }

            }

            Console.WriteLine("Count of Null : " + countNull + ". Count Of One : " + countOne);

            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = binary[i];
            }

            Console.WriteLine("Copied array : ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
