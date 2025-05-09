﻿// Naive Aproach
// Check each element's count in the array.
// Iterate through the array, counting each element's occurrences.
// Return the element with an odd count.
// TIme Complexity O(n*n)

//Optimize
// Use XOR to find the odd occurring number.
// XOR all elements; pairs cancel out, leaving the odd one.
// Return the final XOR result.
// Time Complexity O(n)

namespace _2_BitMagic
{
    class _5_FindOddOccuring
    {
        public static int FindOddOccurring_Naive(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                // Count the occurrences of arr[i]
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                // Check if the count is odd
                if (count % 2 != 0)
                {
                    return arr[i];
                }
            }
            //Return - 1 if no odd occurrence is found (should not happen if the problem guarantees one odd occurring number)
            return -1;
        }

        public static int FindOddOccurring_Optimized(int[] arr)
        {
            int result = 0; // XOR all elements in the array
            foreach (int num in arr)
            {
                result ^= num;
            }
            return result;
        }
    }
}
